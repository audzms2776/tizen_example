#ifndef __basicscrollersubex1_H__
#define __basicscrollersubex1_H__

#include <app.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#include <dlog.h>

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "basicscrollersubex1"

#if !defined(PACKAGE)
#define PACKAGE "org.example.basicscrollersubex1"
#endif
void sub_view_cb(void *data, Evas_Object *obj, void *event_info);
#endif /* __basicscrollersubex1_H__ */
