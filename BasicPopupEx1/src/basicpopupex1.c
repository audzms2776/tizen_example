#include "basicpopupex1.h"

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *label;
	Evas_Object *box;
	Evas_Object *popup;
	Evas_Object *entry;
	int popupNum;
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

static void popup_timeout(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	evas_object_del(obj);
	elm_object_text_set(ad->label, "Time out");
}

static void popup_block_clicked(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	evas_object_del(obj);
	elm_object_text_set(ad->label, "Block Clicked");
}

static void popup_btn1_clicked(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	const char *input;

	if (ad->popupNum == 4) {
		const char *input;
		Eina_Strbuf *str;
		input = elm_entry_entry_get(ad->entry);
		str = eina_strbuf_new();
		eina_strbuf_append_printf(str, "Input: '%s'", input);
		elm_object_text_set(ad->label, eina_strbuf_string_get(str));
		eina_strbuf_free(str);
	} else {
		elm_object_text_set(ad->label, "Popup 1 Button Clicked");
	}


	evas_object_del(ad->popup);
	ad->popup = NULL;
	 ad->entry = NULL;
}

static void popup_btn2_clicked(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	evas_object_del(ad->popup);
	elm_object_text_set(ad->label, "Button-2 Clicked");
}

static void popup_btn3_clicked(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	evas_object_del(ad->popup);
	elm_object_text_set(ad->label, "Button-3 Clicked");
}

static void make_popup_text(void *data, Evas_Object *obj, void *event_info) {

	appdata_s *ad = data;
	ad->popup = elm_popup_add(ad->win);
	elm_popup_align_set(ad->popup, ELM_NOTIFY_ALIGN_FILL, 0.5);
//	evas_object_size_hint_weight_set(ad->popup, EVAS_HINT_EXPAND,
//	EVAS_HINT_EXPAND);
	evas_object_size_hint_weight_set(ad->popup, 200, 40);
	elm_object_text_set(ad->popup, "Text popup - timeout of 3 sec is set.");
	elm_popup_timeout_set(ad->popup, 3.0);
	evas_object_smart_callback_add(ad->popup, "timeout", popup_timeout, ad);
	evas_object_smart_callback_add(ad->popup, "block,clicked",
			popup_block_clicked, ad);
	evas_object_show(ad->popup);
	ad->popupNum = 1;
}

static void make_popup_text_1button(void *data, Evas_Object *obj,
		void *event_info) {
	Evas_Object *btn;
	appdata_s *ad = data;
	ad->popup = elm_popup_add(ad->win);
	elm_popup_align_set(ad->popup, ELM_NOTIFY_ALIGN_FILL, 1.0);
	evas_object_smart_callback_add(ad->popup, "block,clicked",
			popup_block_clicked, ad);
	evas_object_size_hint_weight_set(ad->popup, EVAS_HINT_EXPAND,
	EVAS_HINT_EXPAND);
	elm_object_text_set(ad->popup, "1Button popup");
	btn = elm_button_add(ad->popup);
	elm_object_text_set(btn, "OK");
	elm_object_part_content_set(ad->popup, "button1", btn);
	evas_object_smart_callback_add(btn, "clicked", popup_btn1_clicked, ad);
	evas_object_show(ad->popup);
	ad->popupNum = 2;
}
static void make_popup_text_3button(void *data, Evas_Object *obj,
		void *event_info) {

	Evas_Object *btn;
	appdata_s *ad = data;
	ad->popup = elm_popup_add(ad->conform);
	elm_popup_align_set(ad->popup, ELM_NOTIFY_ALIGN_FILL, 1.0);
	evas_object_smart_callback_add(ad->popup, "block,clicked",
			popup_block_clicked, ad);
	evas_object_size_hint_weight_set(ad->popup, EVAS_HINT_EXPAND,
	EVAS_HINT_EXPAND);
	elm_object_text_set(ad->popup, "3Button popup");

	btn = elm_button_add(ad->popup);
	elm_object_text_set(btn, "OK");
	elm_object_part_content_set(ad->popup, "button1", btn);
	evas_object_smart_callback_add(btn, "clicked", popup_btn1_clicked, ad);
	btn = elm_button_add(ad->popup);
	elm_object_text_set(btn, "Cancel");
	elm_object_part_content_set(ad->popup, "button2", btn);
	evas_object_smart_callback_add(btn, "clicked", popup_btn2_clicked, ad);
	btn = elm_button_add(ad->popup);
	elm_object_text_set(btn, "Close");
	elm_object_part_content_set(ad->popup, "button3", btn);
	evas_object_smart_callback_add(btn, "clicked", popup_btn3_clicked, ad);
	evas_object_show(ad->popup);
	ad->popupNum = 3;

}
static void make_popup_input_text(void *data, Evas_Object *obj,
		void *event_info) {

	Evas_Object *btn;
	appdata_s *ad = data;
	Evas_Object *entry;
	ad->popup = elm_popup_add(ad->box);
	elm_popup_align_set(ad->popup, ELM_NOTIFY_ALIGN_FILL, 1.0);
	evas_object_smart_callback_add(ad->popup, "block,clicked",
			popup_block_clicked, ad);
	evas_object_size_hint_weight_set(ad->popup, EVAS_HINT_EXPAND,
	EVAS_HINT_EXPAND);
	elm_object_part_text_set(ad->popup, "title,text", "Input Text");
	entry = elm_entry_add(ad->popup);
	evas_object_size_hint_weight_set(entry, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(entry, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_object_part_content_set(ad->popup, "elm.swallow.content", entry);
	evas_object_show(entry);
	ad->entry = entry; /* OK button */
	btn = elm_button_add(ad->popup);
	elm_object_text_set(btn, "OK");
	elm_object_part_content_set(ad->popup, "button1", btn);
	evas_object_smart_callback_add(btn, "clicked", popup_btn1_clicked, ad); /* Cancel button */
	btn = elm_button_add(ad->popup);
	elm_object_text_set(btn, "Cancel");
	elm_object_part_content_set(ad->popup, "button2", btn);
	evas_object_smart_callback_add(btn, "clicked", popup_btn2_clicked, ad);
	evas_object_show(ad->popup);
	ad->popupNum = 4;
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

	ad->box = elm_box_add(ad->win);
	evas_object_size_hint_weight_set(ad->box, EVAS_HINT_EXPAND,
	EVAS_HINT_EXPAND);
	elm_object_content_set(ad->conform, ad->box);
	evas_object_show(ad->box);

	{
		ad->label = elm_label_add(ad->conform);
		elm_object_text_set(ad->label, "Please click a button below");
		my_box_pack(ad->box, ad->label, 1.0, 0.0, 0.5, 0.0);

		Evas_Object *btn = elm_button_add(ad->conform);
		elm_object_text_set(btn, "Popup Text");
		evas_object_smart_callback_add(btn, "clicked", make_popup_text, ad);
		my_box_pack(ad->box, btn, 1.0, 0.0, -1.0, -1.0);
		btn = elm_button_add(ad->conform);
		elm_object_text_set(btn, "Popup 1 Button");
		evas_object_smart_callback_add(btn, "clicked", make_popup_text_1button,
				ad);
		my_box_pack(ad->box, btn, 1.0, 0.0, -1.0, -1.0);
		btn = elm_button_add(ad->conform);
		elm_object_text_set(btn, "Popup 3 Buttons");
		evas_object_smart_callback_add(btn, "clicked", make_popup_text_3button,
				ad);
		my_box_pack(ad->box, btn, 1.0, 0.0, -1.0, -1.0);
		btn = elm_button_add(ad->conform);
		elm_object_text_set(btn, "Popup Input Text");
		evas_object_smart_callback_add(btn, "clicked", make_popup_input_text,
				ad);
		my_box_pack(ad->box, btn, 1.0, 1.0, -1.0, 0.0);

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
