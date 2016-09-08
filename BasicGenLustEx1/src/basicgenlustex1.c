#include "basicgenlustex1.h"

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *label;
} appdata_s;

typedef struct item_data {
	int index;
	Elm_Object_Item *item;
} item_data_s;

appdata_s* m_ad = 0;

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

static void list_item_clicked(void *data, Evas_Object *obj, void *event_info) {
	item_data_s *id = data;
	char buf[PATH_MAX];
	sprintf(buf, "Item-%d", id->index);
	elm_object_text_set(m_ad->label, buf);
}

static void gl_del_cb(void *data, Evas_Object *obj) {
	item_data_s *id = data;
	free(id);
}

static char* gl_text_get_cb(void *data, Evas_Object *obj, const char *part) {
	const char *items[] = { "Seoul", "Tokyo", "Newyork", "Londeon", "Baijing",
			"Kongga", "Moscuba", "Singgapol", "Pusan", "Hongkong" };
	item_data_s *id = data;
	if (!strcmp(part, "elm.text")) {
		return strdup(items[id->index]);
	}
	return NULL;
}

static void app_get_resource(const char *res_file_in, char *res_path_out,
		int res_path_max) {
	char *res_path = app_get_resource_path();
	if (res_path) {
		snprintf(res_path_out, res_path_max, "%s%s", res_path, res_file_in);
		free(res_path);
	}
}

static Evas_Object* create_image(Evas_Object *parent) {
	char img_path[PATH_MAX] = { 0, };
	app_get_resource("icon.png", img_path, PATH_MAX);
	Evas_Object *img = elm_image_add(parent);
	elm_image_file_set(img, img_path, NULL);
	return img;
}

static Evas_Object* gl_content_get_cb(void *data, Evas_Object *obj,
		const char *part) {
	Evas_Object *content = create_image(obj);
	evas_object_size_hint_min_set(content, 50, 50);
	evas_object_size_hint_max_set(content, 50, 50);
	return content;
}

static void create_base_gui(appdata_s *ad) {
	m_ad = ad;
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
		Evas_Object *genlist = elm_genlist_add(ad->conform);
		my_box_pack(box, genlist, 1.0, 1.0, -1.0, -1.0);
		Elm_Genlist_Item_Class *itc = elm_genlist_item_class_new();
		itc->item_style = "end_icon";
		itc->func.text_get = gl_text_get_cb;
		itc->func.del = gl_del_cb;
		itc->func.content_get = gl_content_get_cb;

		for (int i = 0; i < 10; i++) {
			item_data_s *id = calloc(sizeof(item_data_s), 1);
			id->index = i;
			id->item = elm_genlist_item_append(genlist, itc, id, NULL,
					ELM_GENLIST_ITEM_NONE, list_item_clicked, id);
//			id->item = elm_genlist_item_append(genlist, itc, id, NULL,
//					ELM_GENLIST_ITEM_NONE, NULL, id);
		}

		elm_genlist_item_class_free(itc);
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
