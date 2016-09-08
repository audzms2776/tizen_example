#include "basicgalleryex1.h"

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *label;
	Evas_Object *gengrid;
	Evas_Object *bg;

} appdata_s;

appdata_s* m_ad = 0;

typedef struct itemdata {
	int index;
	const char *path;
} itemdata_s;

static void win_delete_request_cb(void *data, Evas_Object *obj,
		void *event_info) {
	ui_app_exit();
}

static void my_table_pack(Evas_Object *table, Evas_Object *child, int x, int y,
		int w, int h) {
	evas_object_size_hint_align_set(child, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_weight_set(child, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_table_pack(table, child, x, y, w, h);
	evas_object_show(child);
}

static void win_back_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	/* Let window go to hide state. */
	elm_win_lower(ad->win);
}

static Evas_Object* gengrid_content_get_cb(void *data, Evas_Object *obj,
		const char *part) {
	itemdata_s *id = data;
	if (!strcmp(part, "elm.swallow.icon")) {
		Evas_Object *img = elm_image_add(obj);
		elm_image_file_set(img, id->path, NULL);
		elm_image_aspect_fixed_set(img, EINA_FALSE);
		evas_object_show(img);
		return img;
	}

	return NULL;
}

static void gengrid_it_cb(void *data, Evas_Object *obj, void *event_info) {
	itemdata_s *id = data;
	elm_bg_option_set(m_ad->bg, ELM_BG_OPTION_CENTER);
//	elm_bg_option_set(m_ad->bg, ELM_BG_OPTION_STRETCH);
	elm_bg_file_set(m_ad->bg, id->path, NULL);
}

static Evas_Object* create_gengrid(appdata_s *ad) {
	Elm_Gengrid_Item_Class *gic;
	Evas_Object *gengrid;
	char buf[PATH_MAX];
	gengrid = elm_gengrid_add(ad->conform);
	elm_gengrid_item_size_set(gengrid, ELM_SCALE_SIZE(200),
			ELM_SCALE_SIZE(200));
	elm_gengrid_horizontal_set(gengrid, EINA_TRUE);
	gic = elm_gengrid_item_class_new();
	gic->func.content_get = gengrid_content_get_cb;
	for (int i = 0; i < 10; i++) {
		itemdata_s *id = calloc(sizeof(itemdata_s), 1);
		snprintf(buf, sizeof(buf), "%s%d.png", app_get_resource_path(), i);
		id->index = i;
		id->path = strdup(buf);
		elm_gengrid_item_append(gengrid, gic, id, gengrid_it_cb, id);
//		elm_gengrid_item_append(gengrid, gic, id, NULL, id);
	}

	return gengrid;
}

static void my_box_pack(Evas_Object *box, Evas_Object *child, double h_weight,
		double v_weight, double h_align, double v_align) {

	evas_object_size_hint_weight_set(child, h_weight, v_weight);
	evas_object_size_hint_align_set(child, h_align, v_align);
	evas_object_show(child);
	elm_box_pack_end(box, child);
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

//	Evas_Object *box = elm_box_add(ad->win);
//	evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
//	elm_object_content_set(ad->conform, box);
//	evas_object_show(box);
//
//	{
//		ad->gengrid = create_gengrid(ad);
//		my_box_pack(box, ad->gengrid, 1.0, 1.0, -1.0, -1.0);
//
//		ad->bg = elm_bg_add(ad->win);
//		my_box_pack(box, ad->bg, 1.0, 1.0, -1.0, -1.0);
//	}

	Evas_Object *table = elm_table_add(ad->win); /* Make table homogenous - every cell will be the same size */
	elm_table_homogeneous_set(table, EINA_TRUE);

	evas_object_size_hint_weight_set(table, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_win_resize_object_add(ad->win, table);
	evas_object_show(table);

	{
		ad->gengrid = create_gengrid(ad);
		my_table_pack(table, ad->gengrid, 0, 0, 2, 2);

		ad->bg = elm_bg_add(ad->win);
		my_table_pack(table, ad->bg, 0, 2, 2, 2);
	}
	/* Show window after base gui is set up */
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
