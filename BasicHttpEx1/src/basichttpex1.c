#include "basichttpex1.h"
#include <curl/curl.h>

typedef struct MemoryStruct {
	char *memory;
	size_t size;
} memoryStruct;

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *entry;
	Evas_Object *icon;
	memoryStruct ms;
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

static size_t write_memory_cb(void *contents, size_t size, size_t nmemb,
		void *userp) {
	size_t realsize = size * nmemb;
	memoryStruct *mem = (memoryStruct *) userp;
	mem->memory = realloc(mem->memory, mem->size + realsize + 1);
	if (mem->memory == NULL) {
		dlog_print(DLOG_INFO, "tag",
				"not enough memory (realloc returned NULL)");
		return 0;
	}
	memcpy(&(mem->memory[mem->size]), contents, realsize);
	mem->size += realsize;
	mem->memory[mem->size] = 0;

	return realsize;
}

void get_http_data(const char* url, memoryStruct *data) {
	CURL *curl_handle;
	CURLcode res;

	data->memory = malloc(1); /* will be grown as needed by the realloc above */
	data->size = 0; /* no data at this point */
	curl_global_init(CURL_GLOBAL_ALL); /* init the curl session */
	curl_handle = curl_easy_init(); /* specify URL to get */

	curl_easy_setopt(curl_handle, CURLOPT_URL, url); /* send all data to this function  */
	curl_easy_setopt(curl_handle, CURLOPT_WRITEFUNCTION, write_memory_cb); /* we pass our 'chunk' struct to the callback function */
	curl_easy_setopt(curl_handle, CURLOPT_WRITEDATA, (void * )data); /* some servers don't like requests that are made without a user-agent     field, so we provide one */
	curl_easy_setopt(curl_handle, CURLOPT_USERAGENT, "libcurl-agent/1.0"); /* get it! */

	res = curl_easy_perform(curl_handle); /* cleanup curl stuff */
	curl_easy_cleanup(curl_handle); /* we're done with libcurl, so clean it up */
	curl_global_cleanup();
}

static void btn_download_text(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	char url[100] = { 0, };
	sprintf(url, "52.78.101.62:3000/rep/9770933/proposer/");
	get_http_data(url, &ad->ms);
	elm_object_text_set(ad->entry, ad->ms.memory);
	free(ad->ms.memory);
}

static void btn_download_image(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	char url[100] = { 0, };

	sprintf(url,
			"https://developer.tizen.org/sites/all/themes/tizen_dev_theme/logo.png");
	get_http_data(url, &ad->ms);       // update icon image.

	if (elm_image_memfile_set(ad->icon, ad->ms.memory, ad->ms.size, "png",
			0) == EINA_FALSE) {
		dlog_print(DLOG_DEBUG, "tag", "%s : image setting error ", __func__);
	}

	free(ad->ms.memory);
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
			win_delete_request_cb,
			NULL);
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

	Evas_Object *scroller;
	scroller = elm_scroller_add(ad->win);
	evas_object_size_hint_align_set(scroller, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_weight_set(scroller, EVAS_HINT_EXPAND,
			EVAS_HINT_EXPAND);
	elm_scroller_page_size_set(scroller, 280, 0);
	elm_scroller_bounce_set(scroller, EINA_TRUE, EINA_FALSE);
	elm_scroller_policy_set(scroller, ELM_SCROLLER_POLICY_ON,
			ELM_SCROLLER_POLICY_OFF);

	Evas_Object *vbox = elm_box_add(scroller);
	elm_box_padding_set(vbox, ELM_SCALE_SIZE(10), ELM_SCALE_SIZE(10));
	elm_object_content_set(ad->conform, vbox);
	evas_object_show(vbox);
	{
		ad->entry = elm_entry_add(ad->conform);
		evas_object_size_hint_weight_set(ad->entry, EVAS_HINT_EXPAND,
		EVAS_HINT_EXPAND);
		evas_object_size_hint_align_set(ad->entry, EVAS_HINT_FILL,
		EVAS_HINT_FILL);
		elm_box_pack_end(vbox, ad->entry);
		evas_object_show(ad->entry);

		ad->icon = elm_image_add(ad->conform);
		evas_object_size_hint_weight_set(ad->icon, EVAS_HINT_EXPAND,
		EVAS_HINT_EXPAND);
		evas_object_size_hint_align_set(ad->icon, EVAS_HINT_FILL,
		EVAS_HINT_FILL);
		elm_box_pack_end(vbox, ad->icon);
		evas_object_show(ad->icon);

		Evas_Object *btn = elm_button_add(ad->conform);
		elm_object_text_set(btn, "Text");
		evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, 0);
		evas_object_size_hint_align_set(btn, EVAS_HINT_FILL, 0);
		evas_object_smart_callback_add(btn, "clicked", btn_download_text, ad);
		elm_box_pack_end(vbox, btn);
		evas_object_show(btn);

		btn = elm_button_add(ad->conform);
		elm_object_text_set(btn, "Image");
		evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, 0);
		evas_object_size_hint_align_set(btn, EVAS_HINT_FILL, 0);
		evas_object_smart_callback_add(btn, "clicked", btn_download_image, ad);
		elm_box_pack_end(vbox, btn);
		evas_object_show(btn);
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
