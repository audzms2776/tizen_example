#include "basicnotifyex1.h"

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *label;
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

static Evas_Object* create_notify_top_timeout(Evas_Object *parent) {
	Evas_Object *notify;
	Evas_Object *box;
	Evas_Object *label;

	notify = elm_notify_add(parent);
	elm_notify_align_set(notify, 0.5, 0);
	elm_notify_timeout_set(notify, 2.0); /* Create box for stacking notify message */

	box = elm_box_add(notify);
	evas_object_show(box); /* Create label for notify message */

	label = elm_label_add(box);
	evas_object_size_hint_min_set(label, ELM_SCALE_SIZE(480), 0);
	elm_label_line_wrap_set(label, ELM_WRAP_WORD);
	elm_object_text_set(label,
			"<font align=center>This notification will hide automatically in 3 seconds later.</font>");
	elm_box_pack_end(box, label);
	evas_object_show(label);
	elm_object_content_set(notify, box);

	return notify;
}

static void btn_click_cb(void *data, Evas_Object *obj, void *event_info) {
	Evas_Object *notify = data;
	evas_object_show(notify);
}

static void btn_hide_notify_cb(void *data, Evas_Object *obj, void *event_info) {
	Evas_Object *notify = data;
	evas_object_hide(notify);
}

static Evas_Object* create_notify_top_manual(Evas_Object *parent) {
	Evas_Object *notify;
	Evas_Object *box;
	Evas_Object *label;
	Evas_Object *btn; /* Create notify (top-aligned / hide manually) */

	notify = elm_notify_add(parent);
	elm_notify_align_set(notify, 0.5, 0.0);
	elm_notify_timeout_set(notify, 0.0); /* Create box for stacking notify message and button vertically */

	box = elm_box_add(notify);
	elm_box_horizontal_set(box, EINA_FALSE);
	evas_object_show(box); /* Create label for notify message */

	label = elm_label_add(box);
	evas_object_size_hint_min_set(label, ELM_SCALE_SIZE(480), 0);
	elm_label_line_wrap_set(label, ELM_WRAP_WORD);
	elm_object_text_set(label,
			"<font align=center>Click OK button to hide notification</center>");
	elm_box_pack_end(box, label);
	evas_object_show(label); /* Create button to hide notify */

	btn = elm_button_add(box);
	elm_object_text_set(btn, "OK");
	evas_object_size_hint_min_set(btn, ELM_SCALE_SIZE(80), ELM_SCALE_SIZE(58));
	elm_box_pack_end(box, btn);
	evas_object_show(btn);
	evas_object_smart_callback_add(btn, "clicked", btn_hide_notify_cb, notify);

	elm_object_content_set(notify, box);

	return notify;
}

static Evas_Object* create_notify_top_block(Evas_Object *parent) {
	Evas_Object *notify;
	Evas_Object *box;
	Evas_Object *label; /* Create notify (top-aligned / hide automatically / block outside events) */

	notify = elm_notify_add(parent);
	elm_notify_align_set(notify, 0.5, 0.0);
	elm_notify_timeout_set(notify, 3.0);
	elm_notify_allow_events_set(notify, EINA_FALSE); /* Create box for stacking notify message */

	box = elm_box_add(notify);
	evas_object_show(box); /* Create label for notify message */

	label = elm_label_add(box);
	evas_object_size_hint_min_set(label, ELM_SCALE_SIZE(480), 0);
	elm_label_line_wrap_set(label, ELM_WRAP_WORD);
	elm_object_text_set(label,
			"<font align=center>Outside events are blocked while notification shows.</center>");
	elm_box_pack_end(box, label);
	evas_object_show(label);
	elm_object_content_set(notify, box);
	return notify;
}

static Evas_Object* create_notify_bottom_timeout(Evas_Object *parent) {
	Evas_Object *notify;
	Evas_Object *box;
	Evas_Object *label; /* Create notify (bottom-aligned / hide automatically) */

	notify = elm_notify_add(parent);
	elm_notify_align_set(notify, 0.5, 1.0);
	elm_notify_timeout_set(notify, 3.0); /* Create box for stacking notify message */

	box = elm_box_add(notify);
	evas_object_show(box); /* Create label for notify message */

	label = elm_label_add(box);
	evas_object_size_hint_min_set(label, ELM_SCALE_SIZE(480), 0);
	elm_label_line_wrap_set(label, ELM_WRAP_WORD);
	elm_object_text_set(label,
			"<font align=center>This notification shows at the bottom of the screen.</center>");
	elm_box_pack_end(box, label);
	evas_object_show(label);
	elm_object_content_set(notify, box);

	return notify;
}

static void my_box_pack(Evas_Object *box, Evas_Object *child, double h_weight,
		double v_weight, double h_align, double v_align) {

	evas_object_size_hint_weight_set(child, h_weight, v_weight);
	evas_object_size_hint_align_set(child, h_align, v_align);
	evas_object_show(child);
	elm_box_pack_end(box, child);
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
		int rots[4] = { 0, 90, 180, 270 };
		elm_win_wm_rotation_available_rotations_set(ad->win, (const int *)(&rots), 4);
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

	Evas_Object *box = elm_box_add(ad->win);
	evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_box_padding_set(box, 5 * elm_config_scale_get(),
				5 * elm_config_scale_get());
	elm_object_content_set(ad->conform, box);
	evas_object_show(box);
	{
		ad->label = elm_label_add(ad->conform);
		elm_object_text_set(ad->label, "<align=center>Hello EFL</align>");
		my_box_pack(box, ad->label, 1.0, 0.0, -1.0, 0.5);

		Evas_Object* notify = create_notify_top_timeout(box);

		Evas_Object *btn = elm_button_add(ad->conform);
		elm_object_text_set(btn, "Top / Time out");
		evas_object_smart_callback_add(btn, "clicked", btn_click_cb, notify);
		my_box_pack(box, btn, 1.0, 1.0, -1.0, -1.0);

		notify = create_notify_top_manual(box);

		btn = elm_button_add(ad->conform);
		elm_object_text_set(btn, "Top / Manual");
		evas_object_smart_callback_add(btn, "clicked", btn_click_cb, notify);
		my_box_pack(box, btn, 1.0, 1.0, -1.0, -1.0);

		notify = create_notify_top_block(box);
		btn = elm_button_add(ad->conform);
		elm_object_text_set(btn, "Top / Block");
		evas_object_smart_callback_add(btn, "clicked", btn_click_cb, notify);
		my_box_pack(box, btn, 1.0, 1.0, -1.0, -1.0);

		notify = create_notify_bottom_timeout(box);

		btn = elm_button_add(ad->conform);
		elm_object_text_set(btn, "Bottom / Timeout");
		evas_object_smart_callback_add(btn, "clicked", btn_click_cb, notify);
		my_box_pack(box, btn, 1.0, 1.0, -1.0, -1.0);

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
	elm_app_base_scale_set(1.8);
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
