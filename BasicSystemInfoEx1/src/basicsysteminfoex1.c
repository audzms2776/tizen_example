#include "basicsysteminfoex1.h"
#include <system_info.h>

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *label1;
	Evas_Object *label2;
	Evas_Object *label3;
	Evas_Object *label4;
	Evas_Object *label5;
	Evas_Object *label6
} appdata_s;

static void
win_delete_request_cb(void *data, Evas_Object *obj, void *event_info)
{
	ui_app_exit();
}

static void
win_back_cb(void *data, Evas_Object *obj, void *event_info)
{
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

static Evas_Object * my_button_add(Evas_Object *parent, const char *text,
		Evas_Smart_Cb cb, void *cb_data) {
	Evas_Object *btn;
	btn = elm_button_add(parent);
	evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_object_text_set(btn, text);
	evas_object_smart_callback_add(btn, "clicked", cb, cb_data);

	return btn;
}

static Evas_Object * my_label_add(Evas_Object *parent, const char *text) {
	Evas_Object *label;
	label = elm_label_add(parent);
	elm_object_text_set(label, text);
	return label;
}

static void btn_clicked_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	char buf[100];
	char *sValue = NULL;
	bool bValue = false;
	int nValue = 0;
	int ret;
	ret = system_info_get_platform_bool("http://tizen.org/feature/camera.back",
			&bValue);

	if (ret == SYSTEM_INFO_ERROR_NONE) {
		elm_object_text_set(ad->label1, bValue ? "True" : "False");
	}

	ret = system_info_get_platform_bool(
			"http://tizen.org/feature/network.telephony", &bValue);
	if (ret == SYSTEM_INFO_ERROR_NONE) {
		elm_object_text_set(ad->label3, bValue ? "True" : "False");
	}
}

static void
create_base_gui(appdata_s *ad)
{
	/* Window */
	/* Create and initialize elm_win.
	   elm_win is mandatory to manipulate window. */
	ad->win = elm_win_util_standard_add(PACKAGE, PACKAGE);
	elm_win_autodel_set(ad->win, EINA_TRUE);

	if (elm_win_wm_rotation_supported_get(ad->win)) {
//		int rots[4] = { 0, 90, 180, 270 };
		int rots[4] = { 0 };
//		elm_win_wm_rotation_available_rotations_set(ad->win, (const int *)(&rots), 4);
		elm_win_wm_rotation_available_rotations_set(ad->win,
				(const int *) (&rots), 1);
	}

	evas_object_smart_callback_add(ad->win, "delete,request", win_delete_request_cb, NULL);
	eext_object_event_callback_add(ad->win, EEXT_CALLBACK_BACK, win_back_cb, ad);

	/* Conformant */
	/* Create and initialize elm_conformant.
	   elm_conformant is mandatory for base gui to have proper size
	   when indicator or virtual keypad is visible. */
	ad->conform = elm_conformant_add(ad->win);
	elm_win_indicator_mode_set(ad->win, ELM_WIN_INDICATOR_SHOW);
	elm_win_indicator_opacity_set(ad->win, ELM_WIN_INDICATOR_OPAQUE);
	evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_win_resize_object_add(ad->win, ad->conform);
	evas_object_show(ad->conform);

	Evas_Object *tbl, *btn, *frame, *o;
	tbl = elm_table_add(ad->win);
	elm_table_homogeneous_set(tbl, EINA_TRUE);
	evas_object_show(tbl);
	{
		btn = my_button_add(tbl, "Load System Info", btn_clicked_cb, ad);
		my_table_pack(tbl, btn, 0, 0, 2, 1);

		o = my_label_add(tbl, "Back Camera:");
		my_table_pack(tbl, o, 0, 1, 1, 1);

		ad->label1 = my_label_add(tbl, "");
		my_table_pack(tbl, ad->label1, 1, 1, 1, 1);

		o = my_label_add(tbl, "Front Camera:");
		my_table_pack(tbl, o, 0, 2, 1, 1);

		ad->label2 = my_label_add(tbl, "");
		my_table_pack(tbl, ad->label2, 1, 2, 1, 1);

		o = my_label_add(tbl, "Telephony:");
		my_table_pack(tbl, o, 0, 3, 1, 1);

		ad->label3 = my_label_add(tbl, "");
		my_table_pack(tbl, ad->label3, 1, 3, 1, 1);

	}

	/* Show window after base gui is set up */
	evas_object_show(ad->win);
}

static bool
app_create(void *data)
{
	/* Hook to take necessary actions before main event loop starts
		Initialize UI resources and application's data
		If this function returns true, the main loop of application starts
		If this function returns false, the application is terminated */
	appdata_s *ad = data;

	create_base_gui(ad);

	return true;
}

static void
app_control(app_control_h app_control, void *data)
{
	/* Handle the launch request. */
}

static void
app_pause(void *data)
{
	/* Take necessary actions when application becomes invisible. */
}

static void
app_resume(void *data)
{
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
