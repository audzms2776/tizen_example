#include "basicbuttonex1.h"

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *label;
} appdata_s;

int isClick = 0;
int num = 0;

static void win_back_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	elm_win_iconified_set(ad->win, EINA_TRUE);
}

static void my_box_pack(Evas_Object *box, Evas_Object *child, double h_weight,
		double v_weight, double h_align, double v_align) {

	evas_object_size_hint_weight_set(child, h_weight, v_weight);
	evas_object_size_hint_align_set(child, h_align, v_align);
	evas_object_show(child);
	elm_box_pack_end(box, child);
}

static void btn_default_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s* ad = data;
	if (isClick == 0) {
		elm_object_text_set(obj, "Button Pressed");
		isClick = 1;
	} else {
		elm_object_text_set(obj, "Button Not Pressed");
		isClick = 0;
	}

	elm_object_text_set(ad->label, "Button-1 Pressed");
}

static void btn_icon_reorder_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s* ad = data;
	elm_object_text_set(ad->label, "Button-2 Pressed");
}

static void btn_icon_add_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s* ad = data;

}

static void btn_custom_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s* ad = data;
	elm_object_text_set(obj, "Button Pressed");
	elm_object_text_set(ad->label, "Button-5 Pressed");
}

static void app_get_resource(const char *res_file_in, char *res_path_out,
		int res_path_max) {
	char *res_path = app_get_resource_path();
	if (res_path) {
		snprintf(res_path_out, res_path_max, "%s%s", res_path, res_file_in);
		free(res_path);
	}
}

static void create_base_gui(appdata_s *ad) {
	elm_policy_set(ELM_POLICY_QUIT, ELM_POLICY_QUIT_LAST_WINDOW_CLOSED);
	ad->win = elm_win_util_standard_add(PACKAGE, PACKAGE);
	elm_win_autodel_set(ad->win, EINA_TRUE);
	int rots[4] = { 0, 90, 180, 270 };
	elm_win_wm_rotation_available_rotations_set(ad->win, (const int *) (&rots),
			4);
	eext_object_event_callback_add(ad->win, EEXT_CALLBACK_BACK, win_back_cb,
			ad);

	ad->conform = elm_conformant_add(ad->win);
	elm_win_indicator_mode_set(ad->win, ELM_WIN_INDICATOR_SHOW);
	elm_win_indicator_opacity_set(ad->win, ELM_WIN_INDICATOR_OPAQUE);
	evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND,
	EVAS_HINT_EXPAND);
	elm_win_resize_object_add(ad->win, ad->conform);
	evas_object_show(ad->conform);

	{ /* A box to put things in verticallly - default mode for box */
		Evas_Object *box = elm_box_add(ad->win);
		evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND,
		EVAS_HINT_EXPAND);
		elm_object_content_set(ad->conform, box);
		evas_object_show(box);
		{
			/* Label*/
			ad->label = elm_label_add(ad->conform);
			elm_object_text_set(ad->label, "<align=center>Press a Button</>");
			my_box_pack(box, ad->label, 1.0, 0.0, -1.0, 0.5);

			Evas_Object *btn = elm_button_add(ad->conform);
			elm_object_text_set(btn, "Default style");
			evas_object_smart_callback_add(btn, "clicked", btn_default_cb, ad);
			my_box_pack(box, btn, 1.0, 1.0, -1.0, -1.0);

			btn = elm_button_add(ad->conform);
			elm_object_style_set(btn, "icon_reorder");
			evas_object_smart_callback_add(btn, "clicked", btn_icon_reorder_cb,
					ad);
			my_box_pack(box, btn, 1.0, 1.0, -1.0, -1.0);

			btn = elm_button_add(ad->conform);
			elm_object_style_set(btn, "icon_expand_add");
			evas_object_smart_callback_add(btn, "clicked", btn_icon_add_cb, ad);
			my_box_pack(box, btn, 1.0, 1.0, -1.0, -1.0);

			char edj_path[PATH_MAX] = "";
			app_get_resource("edje/custom_button.edj", edj_path,
					(int) PATH_MAX);
			elm_theme_extension_add(NULL, edj_path);

			btn = elm_button_add(ad->win);
			elm_object_style_set(btn, "customized");
			elm_object_text_set(btn, "Custom style");
			evas_object_smart_callback_add(btn, "clicked", btn_custom_cb, ad);
			my_box_pack(box, btn, 1.0, 1.0, -1.0, -1.0);

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

	ret = ui_app_main(argc, argv, &event_callback, &ad);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "app_main() is failed. err = %d", ret);
	}

	return ret;
}
