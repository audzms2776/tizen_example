#include "basicpreferenceex1.h"
#include <app_preference.h>
#include <stdlib.h>

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *entry1;
	Evas_Object *spinner1;
} appdata_s;

const char *string_key = "string_key";
const char *integer_key = "integer_key";

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
	evas_object_size_hint_align_set(child, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_weight_set(child, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_table_pack(table, child, x, y, w, h);
	evas_object_show(child);
}

static Evas_Object * my_button_add(Evas_Object *parent, const char *text,
		Evas_Smart_Cb cb, void *cb_data) {
	Evas_Object *btn;
	btn = elm_button_add(parent);
	elm_object_text_set(btn, text);
	evas_object_smart_callback_add(btn, "clicked", cb, cb_data);
	return btn;
}

static void btn_save_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	const char *string_value;
	int integer_value;

	string_value = elm_object_text_get(ad->entry1);
	preference_set_string(string_key, string_value);

	integer_value = (int) elm_spinner_value_get(ad->spinner1);
	preference_set_int(integer_key, integer_value);
}

static void btn_read_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	char *string_value = "";
	bool existing = false;
	int integer_value;

	if ((preference_is_existing(string_key, &existing) == 0) && existing) {
		preference_get_string(string_key, &string_value);
		elm_object_text_set(ad->entry1, string_value);
		free(string_value);
	}

	 if ((preference_is_existing(integer_key, &existing) == 0) && existing) {
		preference_get_int(integer_key, &integer_value);
		elm_spinner_value_set(ad->spinner1, (double) integer_value);
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

	Evas_Object *box = elm_box_add(ad->conform);
	evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, 0.0);
	elm_object_content_set(ad->conform, box);
	evas_object_show(box);

	Evas_Object *table = elm_table_add(ad->conform); /* Make table homogenous - every cell will be the same size */
	elm_table_homogeneous_set(table, EINA_TRUE); /* Set padding of 10 pixels multiplied by scale factor of UI */
	elm_table_padding_set(table, 10 * elm_config_scale_get(),
			30 * elm_config_scale_get()); /* Let the table child allocation area expand within in the box */
	evas_object_size_hint_weight_set(table, EVAS_HINT_EXPAND, 0.0); /* Set table to fiill width but align to bottom of box */
	evas_object_size_hint_align_set(table, EVAS_HINT_FILL, 0.0);
	elm_box_pack_end(box, table);
	evas_object_show(table);
	{
		Evas_Object *label = elm_label_add(ad->conform);
		elm_object_text_set(label, "Pet name:");
		my_table_pack(table, label, 0, 0, 1, 1);
		         /* Bg-1 */Evas_Object *bg = elm_bg_add(ad->conform);
		elm_bg_color_set(bg, 210, 210, 210);
		my_table_pack(table, bg, 1, 0, 1, 1);
		            /* Entry-1 */ad->entry1 = elm_entry_add(ad->conform);
		my_table_pack(table, ad->entry1, 1, 0, 1, 1);

		            /* Label-2 */label = elm_label_add(ad->conform);
		elm_object_text_set(label, "Percentage:");
		my_table_pack(table, label, 0, 1, 1, 1);
		            /* Spinner-1 */ad->spinner1 = elm_spinner_add(ad->conform);
		elm_spinner_editable_set(ad->spinner1, EINA_TRUE);
		elm_spinner_interval_set(ad->spinner1, 1);
		elm_spinner_min_max_set(ad->spinner1, 0, 100);
		elm_spinner_label_format_set(ad->spinner1, "%.0f");
		my_table_pack(table, ad->spinner1, 1, 1, 1, 1);
		            Evas_Object *btn;
		            /* Button-Save */btn = my_button_add(ad->conform, "Save", btn_save_cb,
				ad);
		my_table_pack(table, btn, 0, 3, 2, 1);

		btn = my_button_add(ad->conform, "Load", btn_read_cb, ad);
		my_table_pack(table, btn, 0, 2, 2, 1);
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
