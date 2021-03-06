#include "basiccalendarex1.h"
#include <utils_i18n.h>

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *label;
	Evas_Object *label_day[6][7];
	char *tzid;
	i18n_ucalendar_h ucal;
} appdata_s;

static void win_delete_request_cb(void *data, Evas_Object *obj,
		void *event_info) {
	ui_app_exit();
}

static void win_back_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	/* Let window go to hide state. */
	elm_win_lower(ad->win);
}

static void my_table_pack(Evas_Object *table, Evas_Object *child, int x, int y,
		int w, int h) {
	evas_object_size_hint_align_set(child, 0.5, 0.5);
	evas_object_size_hint_weight_set(child, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_table_pack(table, child, x, y, w, h);
	evas_object_show(child);
}

static i18n_ucalendar_h create_time(char *tzid) {
	i18n_ucalendar_h ucal;
	i18n_uchar *_tzid = (i18n_uchar*) calloc(strlen(tzid) + 1,
			sizeof(i18n_uchar));
	i18n_ustring_copy_ua(_tzid, tzid);
	int len = i18n_ustring_get_length(_tzid);
	int ret = i18n_ucalendar_create(_tzid, len, "en_US",
			I18N_UCALENDAR_TRADITIONAL, &ucal);
	return ucal;
}

static char* time2string(i18n_ucalendar_h ucal) {
	int year, month, day, hour, minute, second;
	i18n_ucalendar_get(ucal, I18N_UCALENDAR_YEAR, &year);
	i18n_ucalendar_get(ucal, I18N_UCALENDAR_MONTH, &month);
	i18n_ucalendar_get(ucal, I18N_UCALENDAR_DATE, &day);
	i18n_ucalendar_get(ucal, I18N_UCALENDAR_HOUR, &hour);
	i18n_ucalendar_get(ucal, I18N_UCALENDAR_MINUTE, &minute);
	i18n_ucalendar_get(ucal, I18N_UCALENDAR_SECOND, &second);
	char *buf = malloc(100);
	sprintf(buf, "Now :%04d-%02d-%02d %02d:%02d:%02d", year, month + 1, day,
			hour, minute, second);
	return buf;
}

static void draw_calendar(appdata_s *ad) {
	int date, month, dow, days, is_leap;
	int max_day[] = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
	i18n_ucalendar_get(ad->ucal, I18N_UCALENDAR_DATE, &date);
	i18n_ucalendar_set(ad->ucal, I18N_UCALENDAR_DATE, 1);
	i18n_ucalendar_get(ad->ucal, I18N_UCALENDAR_MONTH, &month);
	i18n_ucalendar_get(ad->ucal, I18N_UCALENDAR_DAY_OF_WEEK, &dow);
	days = max_day[month];
	if (month == 1) {
		i18n_ucalendar_get(ad->ucal, I18N_UCALENDAR_IS_LEAP_MONTH, &is_leap);
		if (is_leap == 1)
			days = 29;
	}
	int i = 0, j = 0;
	char buf[10];
	i = dow - 1;
	for (int d = 1; d <= days; d++) {
		sprintf(buf, "%d", d);
		if (d == date)
			sprintf(buf, "[%d]", d);

		elm_object_text_set(ad->label_day[j][i], buf);
		i++;
		if (i >= 7) {
			i = 0;
			j++;
		}
	}
}

static void create_base_gui(appdata_s *ad) {
	/* Window */
	/* Create and initialize elm_win.
	 elm_win is mandatory to manipulate window. */
	ad->win = elm_win_util_standard_add(PACKAGE, PACKAGE);
	elm_win_autodel_set(ad->win, EINA_TRUE);

	if (elm_win_wm_rotation_supported_get(ad->win)) {
		int rots[4] = { 0, 90, 180, 270 };
		elm_win_wm_rotation_available_rotations_set(ad->win,
				(const int *) (&rots), 4);
	}

	evas_object_smart_callback_add(ad->win, "delete,request",
			win_delete_request_cb, NULL);
	eext_object_event_callback_add(ad->win, EEXT_CALLBACK_BACK, win_back_cb,
			ad);

	Evas_Object *box = elm_box_add(ad->win);
	evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_win_resize_object_add(ad->win, box);
	evas_object_show(box);

	Evas_Object *table = elm_table_add(ad->win);
	elm_table_homogeneous_set(table, EINA_TRUE);
	elm_table_padding_set(table, 10 * elm_config_scale_get(),
			10 * elm_config_scale_get());
	evas_object_size_hint_weight_set(table, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(table, EVAS_HINT_FILL, 0.0);
	elm_box_pack_end(box, table);
	evas_object_show(table);
	{
		ad->label = elm_label_add(ad->win);
		elm_object_text_set(ad->label, "<align=center>Hello EFL</align>");
		my_table_pack(table, ad->label, 0, 0, 7, 1);

		for (int j = 0; j < 6; j++) {
			for (int i = 0; i < 7; i++) {

				ad->label_day[j][i] = elm_label_add(ad->win);
				elm_object_text_set(ad->label_day[j][i], ".");
				my_table_pack(table, ad->label_day[j][i], i, j + 2, 1, 1);
			}
		}
	}

	/* Show window after base gui is set up */
	evas_object_show(ad->win);

	system_settings_get_value_string(SYSTEM_SETTINGS_KEY_LOCALE_TIMEZONE,
			&ad->tzid);
	ad->ucal = create_time(ad->tzid);
	char *buf = time2string(ad->ucal);
	elm_object_text_set(ad->label, buf);

	draw_calendar(ad);
}

static bool app_create(void *data) {
	/* Hook to take necessary actions before main event loop starts
	 Initialize UI resources and application's data
	 If this function returns true, the main loop of application starts
	 If this function returns false, the application is terminated */
	appdata_s *ad = data;

	create_base_gui(ad);

	return true;
}

static void app_control(app_control_h app_control, void *data) {
	/* Handle the launch request. */
}

static void app_pause(void *data) {
	/* Take necessary actions when application becomes invisible. */
}

static void app_resume(void *data) {
	/* Take necessary actions when application becomes visible. */
}

static void
app_terminate(void *data)
{
	/* Release all resources. */
}

static void
ui_app_lang_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LANGUAGE_CHANGED*/

	int ret;
	char *language;

	ret = app_event_get_language(event_info, &language);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "app_event_get_language() failed. Err = %d.", ret);
		return;
	}

	if (language != NULL) {
		elm_language_set(language);
		free(language);
	}
}

static void
ui_app_orient_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_DEVICE_ORIENTATION_CHANGED*/
	return;
}

static void
ui_app_region_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_REGION_FORMAT_CHANGED*/
}

static void
ui_app_low_battery(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_BATTERY*/
}

static void
ui_app_low_memory(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_MEMORY*/
}

int
main(int argc, char *argv[])
{
	appdata_s ad = {0,};
	int ret = 0;

	ui_app_lifecycle_callback_s event_callback = {0,};
	app_event_handler_h handlers[5] = {NULL, };

	event_callback.create = app_create;
	event_callback.terminate = app_terminate;
	event_callback.pause = app_pause;
	event_callback.resume = app_resume;
	event_callback.app_control = app_control;

	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY], APP_EVENT_LOW_BATTERY, ui_app_low_battery, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY], APP_EVENT_LOW_MEMORY, ui_app_low_memory, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED], APP_EVENT_DEVICE_ORIENTATION_CHANGED, ui_app_orient_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED], APP_EVENT_LANGUAGE_CHANGED, ui_app_lang_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED], APP_EVENT_REGION_FORMAT_CHANGED, ui_app_region_changed, &ad);

	ret = ui_app_main(argc, argv, &event_callback, &ad);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "app_main() is failed. err = %d", ret);
	}

	return ret;
}
