S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPD4
Build-Date: 2016.04.11 14:59:15

Crash Information
Process Name: basicjsonparserex1
PID: 20226
Date: 2016-09-11 20:18:41+0900
Executable File Path: /opt/usr/apps/org.example.basicjsonparserex1/bin/basicjsonparserex1
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 20226, uid 5000)

Register Information
r0   = 0x64617465, r1   = 0x64617465
r2   = 0x00000000, r3   = 0xb67e9c51
r4   = 0xb3f9fa3c, r5   = 0xbec2e4dc
r6   = 0x00000001, r7   = 0xb870f988
r8   = 0x64617465, r9   = 0xb87706f8
r10  = 0xbec2e4f0, fp   = 0x00000000
ip   = 0xb27a158c, sp   = 0xbec2e250
lr   = 0xb67e93fb, pc   = 0xb67e9c50
cpsr = 0x20080030

Memory Information
MemTotal:   987012 KB
MemFree:     61652 KB
Buffers:     46140 KB
Cached:     301292 KB
VmPeak:      97712 KB
VmSize:      97708 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19632 KB
VmRSS:       19632 KB
VmData:      30200 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35688 KB
VmPTE:          70 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 20226 TID = 20226
20226 20227 20496 20501 

Maps Information
b144e000 b1c4d000 rw-p [stack:20501]
b1c90000 b1c98000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1ca9000 b1caa000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1cba000 b1cce000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1ce2000 b1ce3000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1cf3000 b1cf6000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1d07000 b1d08000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1d18000 b1d1a000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1d2a000 b1d2c000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1d3c000 b1d4c000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1d5c000 b1d68000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1d7a000 b2579000 rw-p [stack:20496]
b2779000 b2792000 r-xp /usr/lib/libjson-glib-1.0.so.0.0.0
b27a2000 b27a9000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27bc000 b27c2000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27d2000 b27d4000 r-xp /opt/usr/apps/org.example.basicjsonparserex1/bin/basicjsonparserex1
b2924000 b2a07000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a3e000 b2a66000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a78000 b3277000 rw-p [stack:20227]
b3277000 b3279000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3289000 b3293000 r-xp /lib/libnss_files-2.20-2014.11.so
b32a4000 b32ad000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32be000 b32cf000 r-xp /lib/libnsl-2.20-2014.11.so
b32e2000 b32e8000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32f9000 b32fa000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3322000 b3329000 r-xp /usr/lib/libminizip.so.1.0.0
b3339000 b333e000 r-xp /usr/lib/libstorage.so.0.1
b334e000 b33ad000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33c3000 b33d7000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33e7000 b342b000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b343b000 b3443000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3453000 b3483000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3496000 b354f000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3563000 b35b6000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35c7000 b35e2000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35f2000 b36b3000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36c6000 b36d6000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36e6000 b36f3000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3704000 b370b000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b371b000 b375c000 r-xp /usr/lib/libmdm.so.1.2.12
b376c000 b3774000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3783000 b3793000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37b4000 b3814000 r-xp /usr/lib/libasound.so.2.0.0
b3826000 b3829000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3839000 b383c000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b384c000 b3851000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3861000 b3862000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3872000 b387d000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3891000 b3898000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38a8000 b38ae000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38be000 b38c3000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38d3000 b38ee000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38fe000 b3905000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3915000 b3918000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3929000 b3957000 r-xp /usr/lib/libidn.so.11.5.44
b3967000 b397d000 r-xp /usr/lib/libnghttp2.so.5.4.0
b398e000 b3998000 r-xp /usr/lib/libcares.so.2.1.0
b39a8000 b39b2000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39c2000 b39c4000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39d4000 b39d5000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39e5000 b39e9000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39fa000 b3a22000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a33000 b3a5c000 r-xp /usr/lib/libturbojpeg.so
b3a7c000 b3a82000 r-xp /usr/lib/libgif.so.4.1.6
b3a92000 b3ad8000 r-xp /usr/lib/libcurl.so.4.3.0
b3ae9000 b3b0a000 r-xp /usr/lib/libexif.so.12.3.3
b3b25000 b3b3a000 r-xp /usr/lib/libtts.so
b3b4b000 b3b53000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b63000 b3c29000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c49000 b3d41000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d60000 b3e2e000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e45000 b3e47000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e57000 b3e5d000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e6d000 b3e90000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3ea1000 b3ea3000 r-xp /usr/lib/libappsvc.so.0.1.0
b3eb3000 b3eb5000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3ec6000 b3ecb000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3ee2000 b3ee4000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3ef4000 b3efb000 r-xp /usr/lib/libsensord-share.so
b3f0b000 b3f23000 r-xp /usr/lib/libsensor.so.1.1.0
b3f34000 b3f37000 r-xp /usr/lib/libXv.so.1.0.0
b3f47000 b3f4c000 r-xp /usr/lib/libutilX.so.1.1.0
b3f5c000 b3f61000 r-xp /usr/lib/libappcore-common.so.1.1
b3f71000 b3f78000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f8b000 b3f8f000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fa0000 b407e000 r-xp /usr/lib/libCOREGL.so.4.0
b409e000 b40a1000 r-xp /usr/lib/libuuid.so.1.3.0
b40b1000 b40c8000 r-xp /usr/lib/libblkid.so.1.1.0
b40d9000 b40db000 r-xp /usr/lib/libXau.so.6.0.0
b40eb000 b4132000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4144000 b414a000 r-xp /usr/lib/libjson-c.so.2.0.1
b415b000 b415f000 r-xp /usr/lib/libogg.so.0.7.1
b416f000 b4191000 r-xp /usr/lib/libvorbis.so.0.4.3
b41a1000 b4285000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42a1000 b42a4000 r-xp /usr/lib/libEGL.so.1.4
b42b5000 b42bb000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42cb000 b42cd000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42dd000 b42ea000 r-xp /usr/lib/libGLESv2.so.2.0
b42fb000 b435d000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4372000 b438a000 r-xp /usr/lib/libmount.so.1.1.0
b439c000 b43b0000 r-xp /usr/lib/libxcb.so.1.1.0
b43c0000 b43c7000 r-xp /lib/libcrypt-2.20-2014.11.so
b43ff000 b4401000 r-xp /usr/lib/libiri.so
b4411000 b441c000 r-xp /usr/lib/libgpg-error.so.0.15.0
b442d000 b4463000 r-xp /usr/lib/libpulse.so.0.16.2
b4474000 b44b7000 r-xp /usr/lib/libsndfile.so.1.0.25
b44cc000 b44e1000 r-xp /lib/libexpat.so.1.5.2
b44f3000 b45b1000 r-xp /usr/lib/libcairo.so.2.11200.14
b45c5000 b45cd000 r-xp /usr/lib/libdrm.so.2.4.0
b45dd000 b45e0000 r-xp /usr/lib/libdri2.so.0.0.0
b45f0000 b463e000 r-xp /usr/lib/libssl.so.1.0.0
b4653000 b465f000 r-xp /usr/lib/libeeze.so.1.13.0
b4670000 b4679000 r-xp /usr/lib/libethumb.so.1.13.0
b4689000 b468c000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b469c000 b4853000 r-xp /usr/lib/libcrypto.so.1.0.0
b563e000 b5647000 r-xp /usr/lib/libXi.so.6.1.0
b5657000 b5659000 r-xp /usr/lib/libXgesture.so.7.0.0
b5669000 b566d000 r-xp /usr/lib/libXtst.so.6.1.0
b567d000 b5683000 r-xp /usr/lib/libXrender.so.1.3.0
b5693000 b5699000 r-xp /usr/lib/libXrandr.so.2.2.0
b56a9000 b56ab000 r-xp /usr/lib/libXinerama.so.1.0.0
b56bc000 b56bf000 r-xp /usr/lib/libXfixes.so.3.1.0
b56cf000 b56da000 r-xp /usr/lib/libXext.so.6.4.0
b56ea000 b56ec000 r-xp /usr/lib/libXdamage.so.1.1.0
b56fc000 b56fe000 r-xp /usr/lib/libXcomposite.so.1.0.0
b570e000 b57f0000 r-xp /usr/lib/libX11.so.6.3.0
b5804000 b580b000 r-xp /usr/lib/libXcursor.so.1.0.2
b581b000 b5833000 r-xp /usr/lib/libudev.so.1.6.0
b5835000 b5838000 r-xp /lib/libattr.so.1.1.0
b5848000 b5868000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5869000 b586e000 r-xp /usr/lib/libffi.so.6.0.2
b587f000 b5897000 r-xp /lib/libz.so.1.2.8
b58a7000 b58a9000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58b9000 b598e000 r-xp /usr/lib/libxml2.so.2.9.2
b59a3000 b5a3e000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a5a000 b5a5d000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a6d000 b5a86000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a97000 b5aa8000 r-xp /lib/libresolv-2.20-2014.11.so
b5abc000 b5b36000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b4b000 b5b4d000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b5d000 b5b64000 r-xp /usr/lib/libembryo.so.1.13.0
b5b74000 b5b7e000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b8f000 b5ba7000 r-xp /usr/lib/libpng12.so.0.50.0
b5bb8000 b5bdb000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bfc000 b5c10000 r-xp /usr/lib/libector.so.1.13.0
b5c21000 b5c39000 r-xp /usr/lib/liblua-5.1.so
b5c4a000 b5ca1000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cb5000 b5cdd000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cee000 b5d01000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d12000 b5d4c000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d5d000 b5d6b000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d7b000 b5d83000 r-xp /usr/lib/libtbm.so.1.0.0
b5d93000 b5da0000 r-xp /usr/lib/libeio.so.1.13.0
b5db0000 b5db2000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5dc2000 b5dc7000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5dd7000 b5dee000 r-xp /usr/lib/libefreet.so.1.13.0
b5e00000 b5e20000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e30000 b5e50000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e52000 b5e58000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e68000 b5e79000 r-xp /usr/lib/libemotion.so.1.13.0
b5e8a000 b5e91000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ea1000 b5eb0000 r-xp /usr/lib/libeo.so.1.13.0
b5ec1000 b5ed3000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ee4000 b5ee9000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ef9000 b5f12000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f22000 b5f3f000 r-xp /usr/lib/libeet.so.1.13.0
b5f58000 b5fa0000 r-xp /usr/lib/libeina.so.1.13.0
b5fb1000 b5fc1000 r-xp /usr/lib/libefl.so.1.13.0
b5fd2000 b60b7000 r-xp /usr/lib/libicuuc.so.51.1
b60d4000 b6214000 r-xp /usr/lib/libicui18n.so.51.1
b622b000 b6263000 r-xp /usr/lib/libecore_x.so.1.13.0
b6275000 b6278000 r-xp /lib/libcap.so.2.21
b6288000 b62b1000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62c2000 b62c9000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62db000 b6312000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6323000 b640e000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6421000 b649a000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64ac000 b64b1000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64c1000 b64cb000 r-xp /usr/lib/libvconf.so.0.2.45
b64db000 b64dd000 r-xp /usr/lib/libvasum.so.0.3.1
b64ed000 b64ef000 r-xp /usr/lib/libttrace.so.1.1
b64ff000 b6502000 r-xp /usr/lib/libiniparser.so.0
b6512000 b6538000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6548000 b654d000 r-xp /usr/lib/libxdgmime.so.1.1.0
b655e000 b6575000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6586000 b65f1000 r-xp /lib/libm-2.20-2014.11.so
b6602000 b6608000 r-xp /lib/librt-2.20-2014.11.so
b6619000 b6626000 r-xp /usr/lib/libunwind.so.8.0.1
b665c000 b6780000 r-xp /lib/libc-2.20-2014.11.so
b6795000 b67ae000 r-xp /lib/libgcc_s-4.9.so.1
b67be000 b68a0000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68b1000 b68db000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68ec000 b6928000 r-xp /usr/lib/libsystemd.so.0.4.0
b692a000 b69ad000 r-xp /usr/lib/libedje.so.1.13.0
b69c0000 b69de000 r-xp /usr/lib/libecore.so.1.13.0
b69fe000 b6b85000 r-xp /usr/lib/libevas.so.1.13.0
b6bba000 b6bce000 r-xp /lib/libpthread-2.20-2014.11.so
b6be2000 b6e16000 r-xp /usr/lib/libelementary.so.1.13.0
b6e45000 b6e49000 r-xp /usr/lib/libsmack.so.1.0.0
b6e59000 b6e60000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e70000 b6e72000 r-xp /usr/lib/libdlog.so.0.0.0
b6e82000 b6e85000 r-xp /usr/lib/libbundle.so.0.1.22
b6e95000 b6e97000 r-xp /lib/libdl-2.20-2014.11.so
b6ea8000 b6ec0000 r-xp /usr/lib/libaul.so.0.1.0
b6ed4000 b6ed9000 r-xp /usr/lib/libappcore-efl.so.1.1
b6eea000 b6ef7000 r-xp /usr/lib/liblptcp.so
b6f09000 b6f0d000 r-xp /usr/lib/libsys-assert.so
b6f1e000 b6f3e000 r-xp /lib/ld-2.20-2014.11.so
b6f4f000 b6f54000 r-xp /usr/bin/launchpad-loader
b870b000 b894b000 rw-p [heap]
bec0e000 bec2f000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20226)
Call Stack Count: 1
 0: (0xb67e9c50) [/usr/lib/libglib-2.0.so.0] + 0x2bc50
End of Call Stack

Package Information
Package Name: org.example.basicjsonparserex1
Package ID : org.example.basicjsonparserex1
Version: 1.0.0
Package Type: tpk
App Name: jsonparser
App ID: org.example.basicjsonparserex1
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
/AUL     (20212): launch.c: app_request_to_launchpad(425) > request cmd(0) result(19907)
09-11 20:14:49.287+0900 I/APP_CORE(19907): appcore-efl.c: __do_app(514) > [APP 19907] Event: RESET State: CREATED
09-11 20:14:49.287+0900 I/CAPI_APPFW_APPLICATION(19907): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
09-11 20:14:49.287+0900 E/EFL     (19907): edje<19907> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-11 20:14:49.287+0900 E/EFL     (19907): By the power of Grayskull, your previous Embryo stack is now broken!
09-11 20:14:49.287+0900 E/EFL     (19907): edje<19907> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-11 20:14:49.287+0900 E/EFL     (19907): By the power of Grayskull, your previous Embryo stack is now broken!
09-11 20:14:49.287+0900 E/EFL     (19907): edje<19907> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-11 20:14:49.287+0900 E/EFL     (19907): By the power of Grayskull, your previous Embryo stack is now broken!
09-11 20:14:49.297+0900 E/EFL     (19907): edje<19907> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-11 20:14:49.297+0900 E/EFL     (19907): By the power of Grayskull, your previous Embryo stack is now broken!
09-11 20:14:49.297+0900 E/EFL     (19907): edje<19907> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-11 20:14:49.297+0900 E/EFL     (19907): By the power of Grayskull, your previous Embryo stack is now broken!
09-11 20:14:49.318+0900 W/APP_CORE(19907): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5e00002
09-11 20:14:49.318+0900 W/AUL_AMD (  595): amd_request.c: __request_handler(906) > __request_handler: 35
09-11 20:14:49.328+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-11 20:14:49.328+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-11 20:14:49.338+0900 I/Tizen::System( 1340): (259) > Active app [org.exampl], current [org.exampl] 
09-11 20:14:49.338+0900 I/Tizen::System( 1340): (273) > Current App[org.exampl] is already actived.
09-11 20:14:49.358+0900 I/TIZEN_N_SOUND_MANAGER(  905): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=8, ret=0x0
09-11 20:14:49.358+0900 E/TIZEN_N_SOUND_MANAGER(  905): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-11 20:14:49.368+0900 I/TIZEN_N_SOUND_MANAGER(  905): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x0
09-11 20:14:49.368+0900 E/TIZEN_N_SOUND_MANAGER(  905): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-11 20:14:49.368+0900 W/AUL_AMD (  595): amd_request.c: __request_handler(906) > __request_handler: 15
09-11 20:14:49.378+0900 I/APP_CORE(18892): appcore-efl.c: __do_app(514) > [APP 18892] Event: PAUSE State: RUNNING
09-11 20:14:49.378+0900 I/CAPI_APPFW_APPLICATION(18892): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-11 20:14:49.378+0900 I/APP_CORE(19907): appcore-efl.c: __do_app(514) > [APP 19907] Event: RESUME State: CREATED
09-11 20:14:49.388+0900 W/AUL_AMD (  595): amd_launch.c: __e17_status_handler(3328) > pid(18892) status(4)
09-11 20:14:49.388+0900 W/AUL     (  595): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.basiccustombuttonex1(18892)
09-11 20:14:49.388+0900 W/AUL     (  595): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 18892, appid: org.example.basiccustombuttonex1, status: bg
09-11 20:14:49.388+0900 W/AUL_AMD (  595): amd_launch.c: __e17_status_handler(3328) > pid(19907) status(3)
09-11 20:14:49.398+0900 W/AUL_AMD (  595): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-11 20:14:49.398+0900 W/AUL_AMD (  595): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
09-11 20:14:49.398+0900 W/AUL     (  595): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.basicjsonparserex1(19907)
09-11 20:14:49.398+0900 W/AUL     (  595): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 19907, appid: org.example.basicjsonparserex1, status: fg
09-11 20:14:49.398+0900 I/TIZEN_N_EFL_UTIL_WINDOW(18892): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 16
09-11 20:14:49.398+0900 E/APP_CORE(18892): appcore-efl.c: _capture_and_make_file(1619) > win[5c00002] widget[720] height[1280]
09-11 20:14:49.398+0900 I/APP_CORE(19907): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
09-11 20:14:49.398+0900 I/APP_CORE(19907): appcore-efl.c: __do_app(625) > [APP 19907] Initial Launching, call the resume_cb
09-11 20:14:49.398+0900 I/CAPI_APPFW_APPLICATION(19907): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-11 20:14:49.398+0900 W/AUL_AMD (  595): amd_request.c: __request_handler(906) > __request_handler: 33
09-11 20:14:49.738+0900 W/AUL_AMD (  595): amd_launch.c: __e17_status_handler(3328) > pid(19907) status(0)
09-11 20:14:50.268+0900 I/Tizen::App( 1340): (499) > LaunchedApp(org.example.basicjsonparserex1)
09-11 20:14:50.268+0900 I/Tizen::App( 1340): (733) > Finished invoking application event listener for org.example.basicjsonparserex1, 19907.
09-11 20:14:50.278+0900 E/RESOURCED(  714): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1500
09-11 20:14:51.019+0900 I/UXT     (20226): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
09-11 20:14:53.331+0900 E/EFL     (19907): ecore_x<19907> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=51475319
09-11 20:14:54.082+0900 E/EFL     (19907): ecore_x<19907> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=51476068
09-11 20:14:54.402+0900 I/APP_CORE(18892): appcore-efl.c: __do_app(514) > [APP 18892] Event: MEM_FLUSH State: PAUSED
09-11 20:14:55.163+0900 I/CAPI_APPFW_APPLICATION(19907): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-11 20:14:55.163+0900 I/CAPI_APPFW_APPLICATION(  862): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-11 20:14:55.163+0900 I/CAPI_APPFW_APPLICATION(18892): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-11 20:15:00.008+0900 D/AclService( 1441): PowerThread.cpp: processCpuLock(96) > CPU requested: PowerManagerService.WakeLocks
09-11 20:15:00.038+0900 D/AclService( 1441): PowerThread.cpp: processCpuLock(109) > CPU released: PowerManagerService.WakeLocks
09-11 20:15:00.819+0900 I/INDICATOR(  711): clock.c: indicator_clock_changed_cb(195) > ""
09-11 20:15:00.819+0900 E/UXT     (  711): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 8:15
09-11 20:15:00.819+0900 I/INDICATOR(  711): clock.c: getTimeFormatted(176) > "time format : 오후 8:15"
09-11 20:15:00.819+0900 I/INDICATOR(  711): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 8:15"
09-11 20:15:00.819+0900 W/INDICATOR(  711): clock.c: indicator_clock_changed_cb(272) > 
09-11 20:15:00.819+0900 I/INDICATOR(  711): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146624139 Time: <font_size=31> </font_size> <font_size=31> 오후 8:15</font_size></font>"
09-11 20:15:05.013+0900 W/ProcessCpuTracker( 1611): Skipping unknown process pid 20226
09-11 20:15:23.131+0900 I/CAPI_APPFW_APPLICATION(19907): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-11 20:15:23.131+0900 I/CAPI_APPFW_APPLICATION(  862): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-11 20:15:23.131+0900 I/CAPI_APPFW_APPLICATION(18892): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-11 20:16:00.057+0900 D/AclService( 1441): PowerThread.cpp: processCpuLock(96) > CPU requested: PowerManagerService.WakeLocks
09-11 20:16:00.087+0900 D/AclService( 1441): PowerThread.cpp: processCpuLock(109) > CPU released: PowerManagerService.WakeLocks
09-11 20:16:00.817+0900 I/INDICATOR(  711): clock.c: indicator_clock_changed_cb(195) > ""
09-11 20:16:00.827+0900 E/UXT     (  711): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 8:16
09-11 20:16:00.827+0900 I/INDICATOR(  711): clock.c: getTimeFormatted(176) > "time format : 오후 8:16"
09-11 20:16:00.827+0900 I/INDICATOR(  711): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 8:16"
09-11 20:16:00.827+0900 W/INDICATOR(  711): clock.c: indicator_clock_changed_cb(272) > 
09-11 20:16:00.827+0900 I/INDICATOR(  711): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145743959 Time: <font_size=31> </font_size> <font_size=31> 오후 8:16</font_size></font>"
09-11 20:17:00.045+0900 D/AclService( 1441): PowerThread.cpp: processCpuLock(96) > CPU requested: PowerManagerService.WakeLocks
09-11 20:17:00.075+0900 D/AclService( 1441): PowerThread.cpp: processCpuLock(109) > CPU released: PowerManagerService.WakeLocks
09-11 20:17:00.846+0900 I/INDICATOR(  711): clock.c: indicator_clock_changed_cb(195) > ""
09-11 20:17:00.846+0900 E/UXT     (  711): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 8:17
09-11 20:17:00.846+0900 I/INDICATOR(  711): clock.c: getTimeFormatted(176) > "time format : 오후 8:17"
09-11 20:17:00.846+0900 I/INDICATOR(  711): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 8:17"
09-11 20:17:00.846+0900 W/INDICATOR(  711): clock.c: indicator_clock_changed_cb(272) > 
09-11 20:17:00.846+0900 I/INDICATOR(  711): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146583083 Time: <font_size=31> </font_size> <font_size=31> 오후 8:17</font_size></font>"
09-11 20:17:58.993+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __alarm_handler_idle(1754) > Lock the display not to enter LCD OFF
09-11 20:17:58.993+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __display_lock_state(2235) > Lock LCD OFF is successfully done
09-11 20:17:58.993+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __alarm_expired(1526) > zone: /
09-11 20:17:59.003+0900 W/AUL     (  659): app_signal.c: aul_update_freezer_status(354) > send_update_freezer_status, pid: 1030, type: wakeup
09-11 20:17:59.003+0900 E/RESOURCED(  714): file-helper.c: fwrite_str(49) > Fail to open file /sys/fs/cgroup/net_cls/(null)/cgroup.procs
09-11 20:17:59.003+0900 E/RESOURCED(  714): file-helper.c: fwrite_str(49) > errno -2, errmsg No such file or directory
09-11 20:17:59.003+0900 E/RESOURCED(  714): cgroup.c: place_pid_to_cgroup_by_fullpath(76) > Failed place all pid to cgroup /sys/fs/cgroup/net_cls/(null), error No such file or directory
09-11 20:17:59.003+0900 E/RESOURCED(  714): freezer-process.c: freezer_process_pid_set(146) > Cant find process info for 1030
09-11 20:17:59.003+0900 E/ALARM_MANAGER( 1030): alarm-lib.c: __handle_expiry_method_call(170) > [alarm-lib] Alarm expired for [ALARM.apush] : Alarm id [577435189]
09-11 20:17:59.003+0900 E/ALARM_MANAGER( 1030): alarm-lib.c: __handle_expiry_method_call(178) > [alarm-lib] Call expired callback
09-11 20:17:59.023+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __alarm_remove_from_list(639) > [alarm-server]:Remove alarm id(577435189) zone(/)
09-11 20:17:59.023+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
09-11 20:17:59.023+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 11-9-2016, 11:38:31 (UTC).
09-11 20:17:59.023+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
09-11 20:17:59.023+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __alarm_handler_idle(1780) > Unlock the display from LCD OFF
09-11 20:17:59.033+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __display_unlock_state(2278) > Unlock LCD OFF is successfully done
09-11 20:17:59.033+0900 I/AUL     ( 1030): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-11 20:17:59.043+0900 I/AUL     ( 1030): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-11 20:17:59.043+0900 E/ALARM_MANAGER( 1030): alarm-lib.c: alarmmgr_add_alarm_withcb(1281) > trigger_at_time(15), start(11-9-2016, 20:18:14), repeat(0), interval(0), type(-1073741822)
09-11 20:17:59.053+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __get_zone_name(506) > zone name [/]
09-11 20:17:59.053+0900 W/ALARM_MANAGER(  659): alarm-manager.c: __check_privilege_by_cookie(2084) > Get proc/1030/status successfully
09-11 20:17:59.053+0900 W/ALARM_MANAGER(  659): alarm-manager.c: __check_privilege_by_cookie(2093) > uid : 200
09-11 20:17:59.053+0900 W/AUL_AMD (  595): amd_request.c: __request_handler(906) > __request_handler: 15
09-11 20:17:59.053+0900 I/AUL_AMD (  595): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-11 20:17:59.063+0900 I/AUL_AMD (  595): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-11 20:17:59.063+0900 W/AUL_AMD (  595): amd_request.c: __request_handler(906) > __request_handler: 15
09-11 20:17:59.073+0900 I/AUL_AMD (  595): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-11 20:17:59.083+0900 I/AUL_AMD (  595): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-11 20:17:59.083+0900 W/AUL_AMD (  595): amd_request.c: __request_handler(906) > __request_handler: 38
09-11 20:17:59.083+0900 E/AUL_AMD (  595): amd_status.c: _status_get_cmdline(1204) > cmdline : /usr/bin/pushd
09-11 20:17:59.083+0900 E/AUL_AMD (  595): amd_status.c: _status_get_cmdline(1207) > pkt->data : /usr/bin/pushd
09-11 20:17:59.083+0900 E/ALARM_MANAGER(  659): alarm-manager-schedule.c: __alarm_next_duetime_once(152) > Final due_time = 1473592694, Sun Sep 11 20:18:14 2016
09-11 20:17:59.083+0900 E/ALARM_MANAGER(  659): alarm-manager-schedule.c: _alarm_next_duetime(502) > alarm_id: 1583443284, next duetime: 1473592694
09-11 20:17:59.083+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __alarm_add_to_list(562) > [alarm-server]: After add alarm_id(1583443284)
09-11 20:17:59.083+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __alarm_create(1183) > [alarm-server]:alarm_context.c_due_time(1473593911), due_time(1473592694)
09-11 20:17:59.083+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
09-11 20:17:59.083+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 11-9-2016, 11:18:14 (UTC).
09-11 20:17:59.083+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
09-11 20:17:59.633+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __get_zone_name(506) > zone name [/]
09-11 20:17:59.633+0900 W/ALARM_MANAGER(  659): alarm-manager.c: __check_privilege_by_cookie(2084) > Get proc/1030/status successfully
09-11 20:17:59.633+0900 W/ALARM_MANAGER(  659): alarm-manager.c: __check_privilege_by_cookie(2093) > uid : 200
09-11 20:17:59.633+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __alarm_remove_from_list(639) > [alarm-server]:Remove alarm id(1583443284) zone(/)
09-11 20:17:59.633+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
09-11 20:17:59.633+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 11-9-2016, 11:38:31 (UTC).
09-11 20:17:59.633+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
09-11 20:17:59.633+0900 E/ALARM_MANAGER(  659): alarm-manager.c: alarm_manager_alarm_delete(2954) > alarm_id[1583443284] is removed.
09-11 20:17:59.633+0900 E/PUSHD   ( 1030): io.c: server_recv(270) > Fail to recv using curl
09-11 20:17:59.633+0900 E/PUSHD   ( 1030): proc.c: _receive_packet(2312) > ERROR : invalid return when receiving header [-1]
09-11 20:17:59.633+0900 W/PUSHD   ( 1030): ping.c: display_ping_status(380) > = PING_SUCCESS = avg[1200] inc[300] min[1200] max[2400] interval[2400] next_interval[2400] successes[33] max[1] mode[EXPLORE]
09-11 20:17:59.643+0900 I/AUL     ( 1030): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-11 20:17:59.653+0900 I/AUL     ( 1030): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-11 20:17:59.653+0900 E/ALARM_MANAGER( 1030): alarm-lib.c: alarmmgr_add_alarm_withcb(1281) > trigger_at_time(2400), start(11-9-2016, 20:58:00), repeat(0), interval(0), type(-1073741822)
09-11 20:17:59.663+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __get_zone_name(506) > zone name [/]
09-11 20:17:59.663+0900 W/ALARM_MANAGER(  659): alarm-manager.c: __check_privilege_by_cookie(2084) > Get proc/1030/status successfully
09-11 20:17:59.663+0900 W/ALARM_MANAGER(  659): alarm-manager.c: __check_privilege_by_cookie(2093) > uid : 200
09-11 20:17:59.663+0900 W/AUL_AMD (  595): amd_request.c: __request_handler(906) > __request_handler: 15
09-11 20:17:59.673+0900 I/AUL_AMD (  595): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-11 20:17:59.683+0900 I/AUL_AMD (  595): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-11 20:17:59.683+0900 W/AUL_AMD (  595): amd_request.c: __request_handler(906) > __request_handler: 15
09-11 20:17:59.693+0900 I/AUL_AMD (  595): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-11 20:17:59.693+0900 I/AUL_AMD (  595): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-11 20:17:59.693+0900 W/AUL_AMD (  595): amd_request.c: __request_handler(906) > __request_handler: 38
09-11 20:17:59.693+0900 E/AUL_AMD (  595): amd_status.c: _status_get_cmdline(1204) > cmdline : /usr/bin/pushd
09-11 20:17:59.693+0900 E/AUL_AMD (  595): amd_status.c: _status_get_cmdline(1207) > pkt->data : /usr/bin/pushd
09-11 20:17:59.703+0900 E/ALARM_MANAGER(  659): alarm-manager-schedule.c: __alarm_next_duetime_once(152) > Final due_time = 1473595080, Sun Sep 11 20:58:00 2016
09-11 20:17:59.703+0900 E/ALARM_MANAGER(  659): alarm-manager-schedule.c: _alarm_next_duetime(502) > alarm_id: 1583443284, next duetime: 1473595080
09-11 20:17:59.703+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __alarm_add_to_list(562) > [alarm-server]: After add alarm_id(1583443284)
09-11 20:17:59.703+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __alarm_create(1183) > [alarm-server]:alarm_context.c_due_time(1473593911), due_time(1473595080)
09-11 20:17:59.703+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
09-11 20:17:59.703+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 11-9-2016, 11:38:31 (UTC).
09-11 20:17:59.703+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
09-11 20:18:00.044+0900 D/AclService( 1441): PowerThread.cpp: processCpuLock(96) > CPU requested: PowerManagerService.WakeLocks
09-11 20:18:00.084+0900 D/AclService( 1441): PowerThread.cpp: processCpuLock(109) > CPU released: PowerManagerService.WakeLocks
09-11 20:18:00.844+0900 I/INDICATOR(  711): clock.c: indicator_clock_changed_cb(195) > ""
09-11 20:18:00.844+0900 E/UXT     (  711): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 8:18
09-11 20:18:00.844+0900 I/INDICATOR(  711): clock.c: getTimeFormatted(176) > "time format : 오후 8:18"
09-11 20:18:00.844+0900 I/INDICATOR(  711): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 8:18"
09-11 20:18:00.844+0900 W/INDICATOR(  711): clock.c: indicator_clock_changed_cb(272) > 
09-11 20:18:00.844+0900 I/INDICATOR(  711): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146442734 Time: <font_size=31> </font_size> <font_size=31> 오후 8:18</font_size></font>"
09-11 20:18:05.068+0900 W/ProcessCpuTracker( 1611): Skipping unknown process pid 20248
09-11 20:18:21.234+0900 E/PKGMGR_SERVER(20282): pkgmgr-server.c: main(2414) > package manager server start
09-11 20:18:21.274+0900 E/PKGMGR_SERVER(20282): pkgmgr-server.c: __set_recovery_mode(234) > rev_file[/opt/share/packages/.recovery/pkgmgr/org.example.basicjsonparserex1] is null
09-11 20:18:21.284+0900 E/PKGMGR  (20280): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.basicjsonparserex1, -1]
09-11 20:18:21.324+0900 W/AUL_AMD (  595): amd_request.c: __request_handler(906) > __request_handler: 14
09-11 20:18:21.324+0900 W/AUL_AMD (  595): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 19907
09-11 20:18:21.324+0900 W/AUL_AMD (  595): amd_request.c: __request_handler(906) > __request_handler: 12
09-11 20:18:21.324+0900 W/AUL     (20285): launch.c: app_request_to_launchpad(396) > request cmd(5) to(19907)
09-11 20:18:21.324+0900 W/AUL_AMD (  595): amd_request.c: __request_handler(906) > __request_handler: 5
09-11 20:18:21.324+0900 I/APP_CORE(19907): appcore-efl.c: __do_app(514) > [APP 19907] Event: TERMINATE State: RUNNING
09-11 20:18:21.324+0900 W/AUL_AMD (  595): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(19907), cmd(4)
09-11 20:18:21.324+0900 W/AUL     (20285): launch.c: app_request_to_launchpad(425) > request cmd(5) result(0)
09-11 20:18:21.324+0900 W/AUL_AMD (  595): amd_request.c: __request_handler(906) > __request_handler: 22
09-11 20:18:21.324+0900 W/AUL_AMD (  595): amd_request.c: __request_handler(1201) > app status : 5
09-11 20:18:21.324+0900 W/AUL_AMD (  595): amd_request.c: __request_handler(906) > __request_handler: 14
09-11 20:18:21.324+0900 W/AUL_AMD (  595): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
09-11 20:18:21.324+0900 W/AUL_AMD (  595): amd_request.c: __request_handler(906) > __request_handler: 22
09-11 20:18:21.324+0900 W/AUL_AMD (  595): amd_request.c: __request_handler(1201) > app status : 5
09-11 20:18:21.334+0900 E/PKGMGR_SERVER(20282): pkgmgr-server.c: __unset_recovery_mode(282) > remove recovery_file[/opt/share/packages/.recovery/pkgmgr/org.example.basicjsonparserex1] fail
09-11 20:18:21.334+0900 E/PKGMGR_SERVER(20282): pkgmgr-server.c: sighandler(417) > child NORMAL exit [20285]
09-11 20:18:21.334+0900 I/TIZEN_N_EFL_UTIL_WINDOW(19907): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 12
09-11 20:18:21.334+0900 E/APP_CORE(19907): appcore-efl.c: _capture_and_make_file(1619) > win[5e00002] widget[720] height[1280]
09-11 20:18:21.334+0900 W/AUL_AMD (  595): amd_request.c: __request_handler(906) > __request_handler: 33
09-11 20:18:21.334+0900 E/APP_CORE(19907): appcore-efl.c: _capture_and_make_file(1622) > cannot a capture file for the package of [org.example.basicjsonparserex1]
09-11 20:18:21.344+0900 I/CAPI_APPFW_APPLICATION(19907): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-11 20:18:21.344+0900 I/CAPI_APPFW_APPLICATION(19907): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-11 20:18:21.344+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-11 20:18:21.344+0900 W/AUL_AMD (  595): amd_launch.c: __e17_status_handler(3328) > pid(18892) status(3)
09-11 20:18:21.344+0900 W/AUL_AMD (  595): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-11 20:18:21.344+0900 W/AUL_AMD (  595): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
09-11 20:18:21.344+0900 W/AUL     (  595): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.basiccustombuttonex1(18892)
09-11 20:18:21.344+0900 W/AUL     (  595): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 18892, appid: org.example.basiccustombuttonex1, status: fg
09-11 20:18:21.374+0900 W/AUL_AMD (  595): amd_launch.c: __e17_status_handler(3328) > pid(18892) status(0)
09-11 20:18:21.394+0900 I/APP_CORE(18892): appcore-efl.c: __do_app(514) > [APP 18892] Event: RESUME State: PAUSED
09-11 20:18:21.404+0900 I/CAPI_APPFW_APPLICATION(18892): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-11 20:18:21.404+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-11 20:18:21.414+0900 I/Tizen::System( 1340): (259) > Active app [org.exampl], current [org.exampl] 
09-11 20:18:21.414+0900 I/Tizen::System( 1340): (273) > Current App[org.exampl] is already actived.
09-11 20:18:21.434+0900 I/TIZEN_N_SOUND_MANAGER(  905): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=8, ret=0x0
09-11 20:18:21.434+0900 E/TIZEN_N_SOUND_MANAGER(  905): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-11 20:18:21.444+0900 I/TIZEN_N_SOUND_MANAGER(  905): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x0
09-11 20:18:21.444+0900 E/TIZEN_N_SOUND_MANAGER(  905): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-11 20:18:21.444+0900 W/AUL_AMD (  595): amd_request.c: __request_handler(906) > __request_handler: 15
09-11 20:18:21.575+0900 I/AUL_PAD ( 1534): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 19907 pgid = 19907
09-11 20:18:21.575+0900 I/AUL_PAD ( 1534): sigchild.h: __sigchild_action(143) > dead_pid(19907)
09-11 20:18:21.595+0900 I/AUL_PAD ( 1534): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-11 20:18:21.595+0900 I/AUL_PAD ( 1534): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-11 20:18:21.595+0900 E/AUL_PAD ( 1534): launchpad.c: main(698) > error reading sigchld info
09-11 20:18:21.595+0900 I/ESD     (  885): esd_main.c: __esd_app_dead_handler(1773) > pid: 19907
09-11 20:18:21.595+0900 I/Tizen::App( 1340): (243) > App[org.example.basicjsonparserex1] pid[19907] terminate event is forwarded
09-11 20:18:21.595+0900 I/Tizen::System( 1340): (256) > osp.accessorymanager.service provider is found.
09-11 20:18:21.595+0900 I/Tizen::System( 1340): (196) > Accessory Owner is removed [org.example.basicjsonparserex1, 19907, ]
09-11 20:18:21.595+0900 I/Tizen::System( 1340): (256) > osp.system.service provider is found.
09-11 20:18:21.595+0900 I/Tizen::App( 1340): (506) > TerminatedApp(org.example.basicjsonparserex1)
09-11 20:18:21.595+0900 I/Tizen::App( 1340): (512) > Not registered pid(19907)
09-11 20:18:21.595+0900 I/Tizen::System( 1340): (246) > Terminated app [org.example.basicjsonparserex1]
09-11 20:18:21.595+0900 I/Tizen::Io( 1340): (729) > Entry not found
09-11 20:18:21.605+0900 W/AUL_AMD (  595): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 19907
09-11 20:18:21.605+0900 E/RESOURCED(  714): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1505
09-11 20:18:21.615+0900 I/Tizen::System( 1340): (157) > change brightness system value.
09-11 20:18:21.615+0900 I/Tizen::App( 1340): (782) > Finished invoking application event listener for org.example.basicjsonparserex1, 19907.
09-11 20:18:24.017+0900 E/PKGMGR_SERVER(20282): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
09-11 20:18:24.017+0900 E/PKGMGR_SERVER(20282): pkgmgr-server.c: main(2471) > package manager server terminated.
09-11 20:18:26.339+0900 W/AUL_AMD (  595): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-11 20:18:26.339+0900 W/AUL_AMD (  595): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-11 20:18:27.631+0900 E/PKGMGR  (20375): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
09-11 20:18:27.711+0900 E/PKGMGR_SERVER(20377): pkgmgr-server.c: main(2414) > package manager server start
09-11 20:18:27.761+0900 E/PKGMGR_SERVER(20377): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.basicjsonparserex1]
09-11 20:18:27.771+0900 E/PKGMGR_SERVER(20377): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.basicjsonparserex1 errno: 2 (No such file or directory)[0;m
09-11 20:18:27.771+0900 E/PKGMGR_SERVER(20377): pkgmgr-server.c: __set_recovery_mode(234) > rev_file[/opt/share/packages/.recovery/pkgmgr/org.example.basicjsonparserex1] is null
09-11 20:18:27.771+0900 E/PKGMGR  (20375): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[203750002]
09-11 20:18:27.921+0900 I/Tizen::App( 1340): (1894) > PackageEventHandler - req: 13400002, pkg_type: tpk, pkg_name: org.example.basicjsonparserex1, key: start, val: update
09-11 20:18:27.921+0900 I/Tizen::App( 1340): (1584) > Package = [org.example.basicjsonparserex1], Key = [start], Value = [update], install = [1]
09-11 20:18:27.921+0900 I/Tizen::App( 1340): (1584) > Package = [org.example.basicjsonparserex1], Key = [start], Value = [update], install = [1]
09-11 20:18:27.921+0900 W/AUL_AMD (  595): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
09-11 20:18:27.931+0900 I/Tizen::App( 1340): (1894) > PackageEventHandler - req: 13400002, pkg_type: tpk, pkg_name: org.example.basicjsonparserex1, key: install_percent, val: 30
09-11 20:18:27.931+0900 I/Tizen::App( 1340): (119) > InstallationInProgress [30]
09-11 20:18:27.931+0900 I/Tizen::App( 1340): (1584) > Package = [org.example.basicjsonparserex1], Key = [install_percent], Value = [30], install = [1]
09-11 20:18:27.931+0900 I/Tizen::App( 1340): (119) > InstallationInProgress [30]
09-11 20:18:27.931+0900 I/Tizen::App( 1340): (1584) > Package = [org.example.basicjsonparserex1], Key = [install_percent], Value = [30], install = [1]
09-11 20:18:28.031+0900 W/CERT_SVC_VCORE(20380): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
09-11 20:18:28.071+0900 E/rpm-installer(20380): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
09-11 20:18:28.071+0900 E/rpm-installer(20380): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
09-11 20:18:28.121+0900 E/PKGMGR_PARSER(20380): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
09-11 20:18:28.141+0900 E/PKGMGR_CERT(20380): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
09-11 20:18:28.141+0900 E/PKGMGR_CERT(20380): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
09-11 20:18:28.151+0900 E/PKGMGR_CERT(20380): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
09-11 20:18:28.181+0900 E/rpm-installer(20380): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.basicjsonparserex1) failed.
09-11 20:18:28.181+0900 I/Tizen::App( 1340): (1894) > PackageEventHandler - req: 13400002, pkg_type: tpk, pkg_name: org.example.basicjsonparserex1, key: end, val: fail
09-11 20:18:28.181+0900 I/Tizen::App( 1340): (1584) > Package = [org.example.basicjsonparserex1], Key = [end], Value = [fail], install = [96]
09-11 20:18:28.181+0900 I/Tizen::App( 1340): (1584) > Package = [org.example.basicjsonparserex1], Key = [end], Value = [fail], install = [96]
09-11 20:18:28.191+0900 E/ESD     (  885): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
09-11 20:18:28.191+0900 W/AUL_AMD (  595): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
09-11 20:18:28.201+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.basicjsonparserex1",~) returned -1
09-11 20:18:28.201+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
09-11 20:18:30.013+0900 E/PKGMGR_SERVER(20377): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
09-11 20:18:30.463+0900 E/PKGMGR_SERVER(20377): pkgmgr-server.c: __unset_recovery_mode(282) > remove recovery_file[/opt/share/packages/.recovery/pkgmgr/org.example.basicjsonparserex1] fail
09-11 20:18:30.463+0900 E/PKGMGR_SERVER(20377): pkgmgr-server.c: sighandler(417) > child NORMAL exit [20380]
09-11 20:18:32.015+0900 E/PKGMGR_SERVER(20377): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
09-11 20:18:32.015+0900 E/PKGMGR_SERVER(20377): pkgmgr-server.c: main(2471) > package manager server terminated.
09-11 20:18:32.435+0900 E/PKGMGR  (20428): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
09-11 20:18:32.515+0900 E/PKGMGR_SERVER(20430): pkgmgr-server.c: main(2414) > package manager server start
09-11 20:18:32.565+0900 E/PKGMGR_SERVER(20430): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.basicjsonparserex1-1.0.0-arm.tpk]
09-11 20:18:32.575+0900 E/PKGMGR_INFO(20430): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.basicjsonparserex1-1.0.0-arm.tpk] not found in DB
09-11 20:18:32.585+0900 E/rpm-installer(20430): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
09-11 20:18:32.585+0900 E/PKGMGR_SERVER(20430): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
09-11 20:18:32.595+0900 E/PKGMGR_SERVER(20430): pkgmgr-server.c: __set_recovery_mode(234) > rev_file[/opt/share/packages/.recovery/pkgmgr/org.example.basicjsonparserex1-1.0.0-arm.tpk] is null
09-11 20:18:32.595+0900 E/PKGMGR  (20428): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[204280002]
09-11 20:18:32.715+0900 E/PKGMGR_INSTALLER(20433): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
09-11 20:18:32.715+0900 E/rpm-installer(20433): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.basicjsonparserex1-1.0.0-arm.tpk] is tpk package.
09-11 20:18:32.735+0900 E/rpm-installer(20433): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
09-11 20:18:32.735+0900 E/rpm-installer(20433): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
09-11 20:18:32.735+0900 E/rpm-installer(20433): coretpk-parser.c: __coretpk_parser_get_value_list(1104) > (ret == 1) [//*[name() ='privileges']/*[name()='privilege']] is empty.
09-11 20:18:32.735+0900 E/rpm-installer(20433): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
09-11 20:18:32.735+0900 E/rpm-installer(20433): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
09-11 20:18:32.735+0900 E/rpm-installer(20433): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
09-11 20:18:32.796+0900 W/CERT_SVC_VCORE(20433): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
09-11 20:18:32.846+0900 I/Tizen::App( 1340): (1894) > PackageEventHandler - req: 13400002, pkg_type: tpk, pkg_name: org.example.basicjsonparserex1, key: start, val: install
09-11 20:18:32.846+0900 I/Tizen::App( 1340): (1584) > Package = [org.example.basicjsonparserex1], Key = [start], Value = [install], install = [96]
09-11 20:18:32.846+0900 I/Tizen::App( 1340): (1584) > Package = [org.example.basicjsonparserex1], Key = [start], Value = [install], install = [96]
09-11 20:18:32.856+0900 I/Tizen::App( 1340): (1894) > PackageEventHandler - req: 13400002, pkg_type: tpk, pkg_name: org.example.basicjsonparserex1, key: install_percent, val: 30
09-11 20:18:32.856+0900 I/Tizen::App( 1340): (119) > InstallationInProgress [30]
09-11 20:18:32.856+0900 I/Tizen::App( 1340): (1584) > Package = [org.example.basicjsonparserex1], Key = [install_percent], Value = [30], install = [96]
09-11 20:18:32.856+0900 I/Tizen::App( 1340): (119) > InstallationInProgress [30]
09-11 20:18:32.856+0900 I/Tizen::App( 1340): (1584) > Package = [org.example.basicjsonparserex1], Key = [install_percent], Value = [30], install = [96]
09-11 20:18:32.936+0900 E/rpm-installer(20433): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
09-11 20:18:32.936+0900 E/rpm-installer(20433): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
09-11 20:18:32.936+0900 E/rpm-installer(20433): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
09-11 20:18:32.936+0900 E/rpm-installer(20433): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
09-11 20:18:32.936+0900 E/rpm-installer(20433): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
09-11 20:18:32.936+0900 E/rpm-installer(20433): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
09-11 20:18:32.946+0900 E/PKGMGR_PARSER(20433): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
09-11 20:18:32.946+0900 E/PKGMGR_PARSER(20433): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
09-11 20:18:33.176+0900 E/PKGMGR_PARSER(20433): pkgmgr_parser.c: __check_theme(142) > theme for installation.
09-11 20:18:33.196+0900 E/PKGMGR_CERT(20433): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
09-11 20:18:33.196+0900 E/PKGMGR_CERT(20433): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 138
09-11 20:18:33.196+0900 E/PKGMGR_CERT(20433): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 138
09-11 20:18:33.196+0900 E/PKGMGR_CERT(20433): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 46 8
09-11 20:18:33.196+0900 E/PKGMGR_CERT(20433): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 37 31
09-11 20:18:33.196+0900 E/PKGMGR_CERT(20433): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 38 31
09-11 20:18:33.196+0900 E/PKGMGR_CERT(20433): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 47 8
09-11 20:18:33.206+0900 E/PKGMGR_CERT(20433): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
09-11 20:18:33.206+0900 I/Tizen::App( 1340): (1894) > PackageEventHandler - req: 13400002, pkg_type: tpk, pkg_name: org.example.basicjsonparserex1, key: install_percent, val: 60
09-11 20:18:33.216+0900 I/Tizen::App( 1340): (119) > InstallationInProgress [60]
09-11 20:18:33.216+0900 I/Tizen::App( 1340): (1584) > Package = [org.example.basicjsonparserex1], Key = [install_percent], Value = [60], install = [96]
09-11 20:18:33.216+0900 I/Tizen::App( 1340): (119) > InstallationInProgress [60]
09-11 20:18:33.216+0900 I/Tizen::App( 1340): (1584) > Package = [org.example.basicjsonparserex1], Key = [install_percent], Value = [60], install = [96]
09-11 20:18:33.226+0900 E/rpm-installer(20433): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
09-11 20:18:33.246+0900 E/rpm-installer(20433): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
09-11 20:18:33.246+0900 I/Tizen::App( 1340): (1894) > PackageEventHandler - req: 13400002, pkg_type: tpk, pkg_name: org.example.basicjsonparserex1, key: install_percent, val: 100
09-11 20:18:33.246+0900 I/Tizen::App( 1340): (119) > InstallationInProgress [100]
09-11 20:18:33.246+0900 I/Tizen::App( 1340): (1584) > Package = [org.example.basicjsonparserex1], Key = [install_percent], Value = [100], install = [96]
09-11 20:18:33.246+0900 I/Tizen::App( 1340): (119) > InstallationInProgress [100]
09-11 20:18:33.246+0900 I/Tizen::App( 1340): (1584) > Package = [org.example.basicjsonparserex1], Key = [install_percent], Value = [100], install = [96]
09-11 20:18:35.018+0900 E/PKGMGR_SERVER(20430): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
09-11 20:18:35.698+0900 I/Tizen::App( 1340): (1894) > PackageEventHandler - req: 13400002, pkg_type: tpk, pkg_name: org.example.basicjsonparserex1, key: end, val: ok
09-11 20:18:35.698+0900 I/Tizen::App( 1340): (78) > Installation is Completed. [Package = org.example.basicjsonparserex1]
09-11 20:18:35.698+0900 I/Tizen::App( 1340): (671) > Enter. package(org.example.basicjsonparserex1), installationResult(0)
09-11 20:18:35.698+0900 E/cluster-home(  862): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
09-11 20:18:35.698+0900 E/cluster-home(  862): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
09-11 20:18:35.698+0900 E/cluster-home(  862): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
09-11 20:18:35.708+0900 I/Tizen::App( 1340): (1360) > package(org.example.basicjsonparserex1), version(1.0.0), type(tpk), displayName(jsonparser), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.basicjsonparserex1), storeClient(), appRootPath(/opt/usr/apps/org.example.basicjsonparserex1)
09-11 20:18:35.728+0900 I/Tizen::App( 1340): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.basicjsonparserex1]
09-11 20:18:35.728+0900 E/cluster-home(  862): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.basicjsonparserex1]
09-11 20:18:35.728+0900 E/cluster-home(  862): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.basicjsonparserex1]
09-11 20:18:35.728+0900 E/cluster-home(  862): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
09-11 20:18:35.728+0900 E/cluster-home(  862): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
09-11 20:18:35.728+0900 E/cluster-home(  862): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.basicjsonparserex1]
09-11 20:18:35.738+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
09-11 20:18:35.748+0900 E/cluster-home(  862): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[jsonparser] enable[1] system[0]
09-11 20:18:35.748+0900 E/HOME_APPS(  862): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.basicjsonparserex1] mdm is not enabled
09-11 20:18:35.748+0900 E/cluster-home(  862): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[jsonparser] enable[1] system[0]
09-11 20:18:35.748+0900 E/PKGMGR_SERVER(20430): pkgmgr-server.c: __unset_recovery_mode(282) > remove recovery_file[/opt/share/packages/.recovery/pkgmgr/org.example.basicjsonparserex1-1.0.0-arm.tpk] fail
09-11 20:18:35.748+0900 E/PKGMGR_SERVER(20430): pkgmgr-server.c: sighandler(417) > child NORMAL exit [20433]
09-11 20:18:35.748+0900 W/HOME_APPS(  862): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.basicjsonparserex1/shared/res/basicjsonparserex1.png], New icon path[/opt/usr/apps/org.example.basicjsonparserex1/shared/res/basicjsonparserex1.png]!!!!!
09-11 20:18:35.758+0900 I/Tizen::App( 1340): (416) > appName = [basicjsonparserex1]
09-11 20:18:35.758+0900 I/Tizen::App( 1340): (509) > exe = [/opt/usr/apps/org.example.basicjsonparserex1/bin/basicjsonparserex1], displayName = [jsonparser], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
09-11 20:18:35.758+0900 E/PKGMGR_INFO( 1340): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
09-11 20:18:35.758+0900 I/Tizen::App( 1340): (683) > Application count(1) in this package
09-11 20:18:35.758+0900 I/Tizen::App( 1340): (840) > Enter.
09-11 20:18:35.768+0900 I/Tizen::App( 1340): (703) > Exit.
09-11 20:18:35.768+0900 I/Tizen::App( 1340): (1584) > Package = [org.example.basicjsonparserex1], Key = [end], Value = [ok], install = [96]
09-11 20:18:35.768+0900 I/Tizen::App( 1340): (78) > Installation is Completed. [Package = org.example.basicjsonparserex1]
09-11 20:18:35.768+0900 I/Tizen::App( 1340): (1584) > Package = [org.example.basicjsonparserex1], Key = [end], Value = [ok], install = [96]
09-11 20:18:35.768+0900 E/util-view(  862): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
09-11 20:18:35.778+0900 I/Tizen::App( 1340): (416) > appName = [basicjsonparserex1]
09-11 20:18:35.778+0900 I/Tizen::App( 1340): (509) > exe = [/opt/usr/apps/org.example.basicjsonparserex1/bin/basicjsonparserex1], displayName = [jsonparser], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
09-11 20:18:35.778+0900 I/Tizen::App( 1340): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.basicjsonparserex1.info]
09-11 20:18:35.778+0900 I/Tizen::App( 1340): (131) > Enter
09-11 20:18:35.778+0900 I/Tizen::App( 1340): (137) > org.example.basicjsonparserex1 does not have launch condition
09-11 20:18:35.778+0900 I/Tizen::App( 1340): (883) > Exit.
09-11 20:18:37.020+0900 E/PKGMGR_SERVER(20430): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
09-11 20:18:37.020+0900 E/PKGMGR_SERVER(20430): pkgmgr-server.c: main(2471) > package manager server terminated.
09-11 20:18:41.634+0900 W/AUL     (20489): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.basicjsonparserex1)
09-11 20:18:41.634+0900 W/AUL_AMD (  595): amd_request.c: __request_handler(906) > __request_handler: 0
09-11 20:18:41.644+0900 I/AUL     (  595): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
09-11 20:18:41.644+0900 I/AUL     (  595): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
09-11 20:18:41.644+0900 E/AUL_AMD (  595): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
09-11 20:18:41.644+0900 W/AUL_AMD (  595): amd_launch.c: _start_app(2508) > caller pid : 20489
09-11 20:18:41.644+0900 E/AUL_AMD (  595): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
09-11 20:18:41.654+0900 E/RESOURCED(  714): block.c: block_prelaunch_state(134) > insert data org.example.basicjsonparserex1, table num : 20
09-11 20:18:41.654+0900 E/RESOURCED(  714): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-11 20:18:41.654+0900 W/AUL_AMD (  595): amd_launch.c: _start_app(3052) > pad pid(-5)
09-11 20:18:41.664+0900 W/AUL_PAD ( 1534): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
09-11 20:18:41.664+0900 W/AUL_PAD ( 1534): launchpad.c: __send_result_to_caller(267) > Check app launching
09-11 20:18:41.674+0900 I/CAPI_APPFW_APPLICATION(20226): app_main.c: ui_app_main(789) > app_efl_main
09-11 20:18:41.684+0900 I/CAPI_APPFW_APPLICATION(20226): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
09-11 20:18:41.704+0900 E/TBM     (20226): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
09-11 20:18:41.764+0900 W/AUL     (  595): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 20226, appid: org.example.basicjsonparserex1
09-11 20:18:41.764+0900 E/AUL     (  595): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
09-11 20:18:41.764+0900 E/RESOURCED(  714): proc-main.c: proc_add_program_list(237) > not found ppi : org.example.basicjsonparserex1
09-11 20:18:41.774+0900 W/AUL     (20489): launch.c: app_request_to_launchpad(425) > request cmd(0) result(20226)
09-11 20:18:41.964+0900 W/CRASH_MANAGER(20503): worker.c: worker_job(1199) > 1120226626173147359272
