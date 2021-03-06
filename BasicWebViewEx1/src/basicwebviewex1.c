#include "basicwebviewex1.h"
#include <EWebKit.h>
typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *label;
	Evas_Object *entry;
	Evas_Object *web_view;
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
	evas_object_size_hint_align_set(child, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_weight_set(child, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_table_pack(table, child, x, y, w, h);
	evas_object_show(child);
}

static void btn_go_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s* ad = data;
	ewk_view_url_set(ad->web_view, elm_object_text_get(ad->entry));
}
static void btn_prev_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s* ad = data;
	if (ewk_view_back_possible(ad->web_view) == EINA_TRUE)
		ewk_view_back(ad->web_view);
}
static void btn_next_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s* ad = data;
	if (ewk_view_forward_possible(ad->web_view) == EINA_TRUE)
		ewk_view_forward(ad->web_view);
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

		evas_object_size_hint_weight_set(table, EVAS_HINT_EXPAND,
		EVAS_HINT_EXPAND);
		elm_win_resize_object_add(ad->win, table);
		evas_object_show(table);
		{
			ad->entry = elm_entry_add(ad->win);
			elm_entry_scrollable_set(ad->entry, EINA_TRUE);
			eext_entry_selection_back_event_allow_set(ad->entry, EINA_TRUE);
			elm_object_text_set(ad->entry, "http://www.tizen.org");
			my_table_pack(table, ad->entry, 0, 0, 3, 1);

			Evas_Object *btn = elm_button_add(ad->win);
			elm_object_text_set(btn, "Prev");
			evas_object_smart_callback_add(btn, "clicked", btn_prev_cb, ad);
			my_table_pack(table, btn, 0, 1, 1, 1);

			btn = elm_button_add(ad->win);
			elm_object_text_set(btn, "Go");
			evas_object_smart_callback_add(btn, "clicked", btn_go_cb, ad);
			my_table_pack(table, btn, 1, 1, 1, 1);

			btn = elm_button_add(ad->win);
			elm_object_text_set(btn, "Next");
			evas_object_smart_callback_add(btn, "clicked", btn_next_cb, ad);
			my_table_pack(table, btn, 2, 1, 1, 1);

			/* WebView */
			Evas *evas = evas_object_evas_get(ad->win);
			ad->web_view = ewk_view_add(evas);
			ewk_view_url_set(ad->web_view, elm_object_text_get(ad->entry));
			my_table_pack(table, ad->web_view, 0, 2, 3, 8);
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
