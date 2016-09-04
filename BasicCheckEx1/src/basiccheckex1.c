#include "basiccheckex1.h"

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *label;
	Evas_Object *check1;
	Evas_Object *check2;
	Evas_Object *check3;
	Evas_Object *check4;
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

static void check_changed_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	int check_num = 0;
	if (obj == ad->check1)
		check_num = 1;
	else if (obj == ad->check2)
		check_num = 2;
	else if (obj == ad->check3)
		check_num = 3;
	else
		return;

	Eina_Bool state = elm_check_state_get(obj);
	char buf[64];
	sprintf(buf, "Check-%d is %s", check_num, state ? "checked" : "unchecked");
	elm_object_text_set(ad->label, buf);
}

static void my_box_pack(Evas_Object *box, Evas_Object *child, double h_weight,
		double v_weight, double h_align, double v_align) {

	evas_object_size_hint_weight_set(child, h_weight, v_weight);
	evas_object_size_hint_align_set(child, h_align, v_align);
	evas_object_show(child);
	elm_box_pack_end(box, child);
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

	/* Conformant */
	/* Create and initialize elm_conformant.
	 elm_conformant is mandatory for base gui to have proper size
	 when indicator or virtual keypad is visible. */
	ad->conform = elm_conformant_add(ad->win);
	elm_win_indicator_mode_set(ad->win, ELM_WIN_INDICATOR_SHOW);
	elm_win_indicator_opacity_set(ad->win, ELM_WIN_INDICATOR_OPAQUE);
	evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND,
	EVAS_HINT_EXPAND);
	elm_win_resize_object_add(ad->win, ad->conform);
	evas_object_show(ad->conform);

	Evas_Object *box = elm_box_add(ad->win);
	evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_object_content_set(ad->conform, box);
	evas_object_show(box);
	{
		ad->label = elm_label_add(ad->conform);
		elm_object_text_set(ad->label, "<align=center>Hello EFL</align>");
		my_box_pack(box, ad->label, 1.0, 0.0, -1.0, 0.5);

		ad->check1 = elm_check_add(ad->conform);
		elm_object_style_set(ad->check1, "popup");
		elm_object_text_set(ad->check1, "Editable");
		evas_object_smart_callback_add(ad->check1, "changed", check_changed_cb,
				ad);
		my_box_pack(box, ad->check1, 1.0, 1.0, -1.0, -1.0);

		ad->check2 = elm_check_add(ad->conform);
		elm_object_style_set(ad->check2, "favorite");
		elm_object_text_set(ad->check2, "Favorite");
		elm_check_state_set(ad->check2, EINA_TRUE);
		evas_object_smart_callback_add(ad->check2, "changed", check_changed_cb,
				ad);
		my_box_pack(box, ad->check2, 1.0, 1.0, -1.0, -1.0);

		ad->check3 = elm_check_add(ad->conform);
		elm_object_style_set(ad->check3, "on&off");
		elm_object_text_set(ad->check3, "On / Off");
		elm_check_state_set(ad->check3, EINA_FALSE);
		evas_object_smart_callback_add(ad->check3, "changed", check_changed_cb,
				ad);
		my_box_pack(box, ad->check3, 1.0, 1.0, -1.0, -1.0);

		ad->check4 = elm_check_add(ad->conform);
		elm_object_style_set(ad->check4, "on&off");
		elm_object_text_set(ad->check4, "Disable");
		elm_object_disabled_set(ad->check4, EINA_TRUE);
		evas_object_smart_callback_add(ad->check4, "changed", check_changed_cb,
				ad);
		my_box_pack(box, ad->check4, 1.0, 1.0, -1.0, -1.0);

	}

	evas_object_show(ad->win);
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

static void app_terminate(void *data) {
	/* Release all resources. */
}

static void ui_app_lang_changed(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_LANGUAGE_CHANGED*/
	char *locale = NULL;
	system_settings_get_value_string(SYSTEM_SETTINGS_KEY_LOCALE_LANGUAGE,
			&locale);
	elm_language_set(locale);
	free(locale);
	return;
}

static void ui_app_orient_changed(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_DEVICE_ORIENTATION_CHANGED*/
	return;
}

static void ui_app_region_changed(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_REGION_FORMAT_CHANGED*/
}

static void ui_app_low_battery(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_LOW_BATTERY*/
}

static void ui_app_low_memory(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_LOW_MEMORY*/
}

int main(int argc, char *argv[]) {
	appdata_s ad = { 0, };
	int ret = 0;

	ui_app_lifecycle_callback_s event_callback = { 0, };
	app_event_handler_h handlers[5] = { NULL, };

	event_callback.create = app_create;
	event_callback.terminate = app_terminate;
	event_callback.pause = app_pause;
	event_callback.resume = app_resume;
	event_callback.app_control = app_control;

	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY],
			APP_EVENT_LOW_BATTERY, ui_app_low_battery, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY],
			APP_EVENT_LOW_MEMORY, ui_app_low_memory, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED],
			APP_EVENT_DEVICE_ORIENTATION_CHANGED, ui_app_orient_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED],
			APP_EVENT_LANGUAGE_CHANGED, ui_app_lang_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED],
			APP_EVENT_REGION_FORMAT_CHANGED, ui_app_region_changed, &ad);

	ret = ui_app_main(argc, argv, &event_callback, &ad);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "app_main() is failed. err = %d", ret);
	}

	return ret;
}
