#include "basictabex1.h"

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *label;
	Evas_Object *box1;
	Evas_Object *box2;
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

static void my_box_pack(Evas_Object *box, Evas_Object *child, double h_weight,
		double v_weight, double h_align, double v_align) {

	evas_object_size_hint_weight_set(child, h_weight, v_weight);
	evas_object_size_hint_align_set(child, h_align, v_align);
	evas_object_show(child);
	elm_box_pack_end(box, child);
}

static void my_table_pack(Evas_Object *table, Evas_Object *child, int x, int y,
		int w, int h) {
	evas_object_size_hint_align_set(child, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_weight_set(child, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_table_pack(table, child, x, y, w, h);
	evas_object_show(child);
}

static void btn_tab1_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	evas_object_show(ad->box1);
	evas_object_hide(ad->box2);
}

static void btn_tab2_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	evas_object_hide(ad->box1);
	evas_object_show(ad->box2);
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
	{
		Evas_Object *table = elm_table_add(ad->win); /* Make table homogenous - every cell will be the same size */
		elm_table_homogeneous_set(table, EINA_TRUE);
		elm_table_padding_set(table, 5 * elm_config_scale_get(),
				5 * elm_config_scale_get());
		evas_object_size_hint_weight_set(table, EVAS_HINT_EXPAND,
		EVAS_HINT_EXPAND);
		elm_win_resize_object_add(ad->win, table);
		elm_box_pack_end(box, table);
		evas_object_show(table);
		{
			Evas_Object *btn = elm_button_add(ad->win);
			elm_object_text_set(btn, "Tab-1");
			evas_object_smart_callback_add(btn, "clicked", btn_tab1_cb, ad);
			my_table_pack(table, btn, 0, 5, 1, 1);

			btn = elm_button_add(ad->win);
			elm_object_text_set(btn, "Tab-2");
			evas_object_smart_callback_add(btn, "clicked", btn_tab2_cb, ad);
			my_table_pack(table, btn, 1, 5, 1, 1);

			Evas_Object *layout1 = elm_layout_add(ad->win);
			elm_layout_theme_set(layout1, "layout", "drawer", "panel");
			my_table_pack(table, layout1, 0, 0, 2, 5);
			ad->box1 = elm_box_add(layout1);
			elm_win_resize_object_add(ad->win, ad->box1);
			evas_object_show(ad->box1);
			{
				ad->label = elm_label_add(layout1);
				elm_object_text_set(ad->label, "Tab-1");
				my_box_pack(ad->box1, ad->label, 1.0, 0.0, -1.0, 0.5);
			}

			Evas_Object *layout2 = elm_layout_add(ad->win);
			elm_layout_theme_set(layout2, "layout", "drawer", "panel");
			my_table_pack(table, layout2, 0, 0, 2, 5);
			ad->box2 = elm_box_add(layout2);
			elm_win_resize_object_add(ad->win, ad->box2);
			evas_object_hide(ad->box2);
			{
				btn = elm_button_add(layout2);
				elm_object_text_set(btn, "Tab-2");
				my_box_pack(ad->box2, btn, 1.0, 0.0, -1.0, 0.5);
			}
		}
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
