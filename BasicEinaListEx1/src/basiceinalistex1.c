#include "basiceinalistex1.h"

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *label;
	Evas_Object *list;
	Evas_Object *button;
	Eina_List *data_list;
} appdata_s;

typedef struct {
	appdata_s *ad;
	char *data;
	int id;
} itemdata_s;

const char *items[] = { "Seoul", "Tokyo", "New York", "London", "Beijing",
		"Moscow", "Singapore", "Busan", "Hong Kong", "Paris", NULL };

static void win_delete_request_cb(void *data, Evas_Object *obj,
		void *event_info) {
	ui_app_exit();
}

static Evas_Object* create_box(Evas_Object *parent) {
	Evas_Object *box = elm_box_add(parent);
	evas_object_show(box);
	return box;
}

static void win_back_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	/* Let window go to hide state. */
	elm_win_lower(ad->win);
}

static void item_del_cb(void *data, Evas_Object *obj, void *event_info) { /* Those are the arguments */
	Elm_Widget_Item *it = event_info;
	itemdata_s *idata = data;
	(void) it;
	idata->ad->data_list = eina_list_remove(idata->ad->data_list, idata);
	free(idata->data);
	free(idata);
}

static void list_item_clicked_cb(void *data, Evas_Object *obj, void *event_info) {
	itemdata_s *idata = data;
	char buf[256];
	snprintf(buf, 256, "%d. %s", idata->id, idata->data);
	elm_object_text_set(idata->ad->label, buf);
}

static void populate_list(appdata_s *ad) {
	for (unsigned i = 0; items[i]; i++) {
		itemdata_s *idata = calloc(1, sizeof(itemdata_s));
		idata->ad = ad;
		idata->data = strdup(items[i]);
		idata->id = i + 1;
		ad->data_list = eina_list_append(ad->data_list, idata);

//		elm_list_item_append(ad->list, items[i], NULL, NULL, NULL, NULL);

		itemdata_s *itemdata = eina_list_nth(ad->data_list, i);
//		elm_list_item_append(ad->list, itemdata->data, NULL, NULL, NULL, NULL);
		Elm_List_Item *eli;
		eli = elm_list_item_append(ad->list, itemdata->data, NULL, NULL,
				list_item_clicked_cb, idata);
		elm_object_item_del_cb_set(eli, item_del_cb);
	}

	elm_list_go(ad->list);
}

static void btn_clicked_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	Elm_List_Item *it;

	if (!elm_list_items_get(ad->list)) {
		elm_object_text_set(ad->button, "Remove");
		populate_list(ad);
		return;
	}

	it = elm_list_selected_item_get(ad->list);

	if (!it) {
		elm_object_text_set(ad->label, "No item selected");
		return;
	}

	elm_object_item_del(it);

	if (!ad->data_list) {
		elm_object_text_set(ad->button, "Populate");
		return;
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

	Evas_Object *box = create_box(ad->win);
	elm_box_padding_set(box, 10, 10);
	evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_object_content_set(ad->conform, box);
	{
		ad->label = elm_label_add(ad->conform);
		elm_object_text_set(ad->label, "Please select an item");
		evas_object_size_hint_weight_set(ad->label, EVAS_HINT_EXPAND, 0);
		evas_object_size_hint_align_set(ad->label, EVAS_HINT_FILL, 0.5);
		elm_box_pack_end(box, ad->label);
		evas_object_show(ad->label);

		ad->button = elm_button_add(ad->conform);
		elm_object_text_set(ad->button, "Remove");
		evas_object_smart_callback_add(ad->button, "clicked", btn_clicked_cb,
				ad);
		evas_object_size_hint_weight_set(ad->button, EVAS_HINT_EXPAND, 0);
		evas_object_size_hint_align_set(ad->button, EVAS_HINT_FILL, 0.5);
		elm_box_pack_end(box, ad->button);
		evas_object_show(ad->button);

		ad->list = elm_list_add(ad->conform);
		elm_list_mode_set(ad->list, ELM_LIST_COMPRESS);
		evas_object_size_hint_weight_set(ad->list, EVAS_HINT_EXPAND,
		EVAS_HINT_EXPAND);
		evas_object_size_hint_align_set(ad->list, EVAS_HINT_FILL,
		EVAS_HINT_FILL);
		elm_box_pack_end(box, ad->list);
	}

	populate_list(ad);
	elm_list_go(ad->list);
	evas_object_show(ad->list);

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
