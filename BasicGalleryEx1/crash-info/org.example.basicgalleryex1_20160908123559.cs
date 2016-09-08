S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPD4
Build-Date: 2016.04.11 14:59:15

Crash Information
Process Name: basicgalleryex1
PID: 7813
Date: 2016-09-08 12:35:59+0900
Executable File Path: /opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 7813, uid 5000)

Register Information
r0   = 0xb8eea640, r1   = 0x00000000
r2   = 0xb281fc08, r3   = 0x8001369c
r4   = 0xb8ec3a68, r5   = 0xb8ec08b0
r6   = 0x8001369c, r7   = 0xbedee0d0
r8   = 0xb2817931, r9   = 0xbedee0fc
r10  = 0xb8ec6a58, fp   = 0xbedee284
ip   = 0x8000cc67, sp   = 0xbedee0a8
lr   = 0xb8eea640, pc   = 0xb2817950
cpsr = 0xa00d0030

Memory Information
MemTotal:   987012 KB
MemFree:    131524 KB
Buffers:     20888 KB
Cached:     223616 KB
VmPeak:     115288 KB
VmSize:     115284 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22108 KB
VmRSS:       22108 KB
VmData:      32764 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35620 KB
VmPTE:          88 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 7813 TID = 7813
7813 7815 7840 7845 

Maps Information
b14a3000 b1ca2000 rw-p [stack:7845]
b1ce5000 b1ced000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1cfe000 b1cff000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1d0f000 b1d23000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1d37000 b1d38000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1d48000 b1d4b000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1d5c000 b1d5d000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1d6d000 b1d6f000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1d7f000 b1d81000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1d91000 b1da1000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1db1000 b1dbd000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1dcf000 b25ce000 rw-p [stack:7840]
b27ce000 b27d5000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27e6000 b27ee000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b2800000 b2806000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2816000 b2818000 r-xp /opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1
b2968000 b2a4b000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a82000 b2aaa000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2abc000 b32bb000 rw-p [stack:7815]
b32bb000 b32bd000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32cd000 b32d7000 r-xp /lib/libnss_files-2.20-2014.11.so
b32e8000 b32f1000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3302000 b3313000 r-xp /lib/libnsl-2.20-2014.11.so
b3326000 b332c000 r-xp /lib/libnss_compat-2.20-2014.11.so
b333d000 b333e000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3366000 b336d000 r-xp /usr/lib/libminizip.so.1.0.0
b337d000 b3382000 r-xp /usr/lib/libstorage.so.0.1
b3392000 b33f1000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3407000 b341b000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b342b000 b346f000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b347f000 b3487000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3497000 b34c7000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34da000 b3593000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35a7000 b35fa000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b360b000 b3626000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3636000 b36f7000 r-xp /usr/lib/libprotobuf.so.9.0.1
b370a000 b371a000 r-xp /usr/lib/libefl-assist.so.0.1.0
b372a000 b3737000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3748000 b374f000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b375f000 b37a0000 r-xp /usr/lib/libmdm.so.1.2.12
b37b0000 b37b8000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37c7000 b37d7000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37f8000 b3858000 r-xp /usr/lib/libasound.so.2.0.0
b386a000 b386d000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b387d000 b3880000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3890000 b3895000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38a5000 b38a6000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38b6000 b38c1000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38d5000 b38dc000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38ec000 b38f2000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3902000 b3907000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3917000 b3932000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3942000 b3949000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3959000 b395c000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b396d000 b399b000 r-xp /usr/lib/libidn.so.11.5.44
b39ab000 b39c1000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39d2000 b39dc000 r-xp /usr/lib/libcares.so.2.1.0
b39ec000 b39f6000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a06000 b3a08000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a18000 b3a19000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a29000 b3a2d000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a3e000 b3a66000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a77000 b3aa0000 r-xp /usr/lib/libturbojpeg.so
b3ac0000 b3ac6000 r-xp /usr/lib/libgif.so.4.1.6
b3ad6000 b3b1c000 r-xp /usr/lib/libcurl.so.4.3.0
b3b2d000 b3b4e000 r-xp /usr/lib/libexif.so.12.3.3
b3b69000 b3b7e000 r-xp /usr/lib/libtts.so
b3b8f000 b3b97000 r-xp /usr/lib/libfeedback.so.0.1.4
b3ba7000 b3c6d000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c8d000 b3d85000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3da4000 b3e72000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e89000 b3e8b000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e9b000 b3ea1000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3eb1000 b3ed4000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3ee5000 b3ee7000 r-xp /usr/lib/libappsvc.so.0.1.0
b3ef7000 b3ef9000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f0a000 b3f0f000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f26000 b3f28000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f38000 b3f3f000 r-xp /usr/lib/libsensord-share.so
b3f4f000 b3f67000 r-xp /usr/lib/libsensor.so.1.1.0
b3f78000 b3f7b000 r-xp /usr/lib/libXv.so.1.0.0
b3f8b000 b3f90000 r-xp /usr/lib/libutilX.so.1.1.0
b3fa0000 b3fa5000 r-xp /usr/lib/libappcore-common.so.1.1
b3fb5000 b3fbc000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fcf000 b3fd3000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fe4000 b40c2000 r-xp /usr/lib/libCOREGL.so.4.0
b40e2000 b40e5000 r-xp /usr/lib/libuuid.so.1.3.0
b40f5000 b410c000 r-xp /usr/lib/libblkid.so.1.1.0
b411d000 b411f000 r-xp /usr/lib/libXau.so.6.0.0
b412f000 b4176000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4188000 b418e000 r-xp /usr/lib/libjson-c.so.2.0.1
b419f000 b41a3000 r-xp /usr/lib/libogg.so.0.7.1
b41b3000 b41d5000 r-xp /usr/lib/libvorbis.so.0.4.3
b41e5000 b42c9000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42e5000 b42e8000 r-xp /usr/lib/libEGL.so.1.4
b42f9000 b42ff000 r-xp /usr/lib/libxcb-render.so.0.0.0
b430f000 b4311000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4321000 b432e000 r-xp /usr/lib/libGLESv2.so.2.0
b433f000 b43a1000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43b6000 b43ce000 r-xp /usr/lib/libmount.so.1.1.0
b43e0000 b43f4000 r-xp /usr/lib/libxcb.so.1.1.0
b4404000 b440b000 r-xp /lib/libcrypt-2.20-2014.11.so
b4443000 b4445000 r-xp /usr/lib/libiri.so
b4455000 b4460000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4471000 b44a7000 r-xp /usr/lib/libpulse.so.0.16.2
b44b8000 b44fb000 r-xp /usr/lib/libsndfile.so.1.0.25
b4510000 b4525000 r-xp /lib/libexpat.so.1.5.2
b4537000 b45f5000 r-xp /usr/lib/libcairo.so.2.11200.14
b4609000 b4611000 r-xp /usr/lib/libdrm.so.2.4.0
b4621000 b4624000 r-xp /usr/lib/libdri2.so.0.0.0
b4634000 b4682000 r-xp /usr/lib/libssl.so.1.0.0
b4697000 b46a3000 r-xp /usr/lib/libeeze.so.1.13.0
b46b4000 b46bd000 r-xp /usr/lib/libethumb.so.1.13.0
b46cd000 b46d0000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46e0000 b4897000 r-xp /usr/lib/libcrypto.so.1.0.0
b5682000 b568b000 r-xp /usr/lib/libXi.so.6.1.0
b569b000 b569d000 r-xp /usr/lib/libXgesture.so.7.0.0
b56ad000 b56b1000 r-xp /usr/lib/libXtst.so.6.1.0
b56c1000 b56c7000 r-xp /usr/lib/libXrender.so.1.3.0
b56d7000 b56dd000 r-xp /usr/lib/libXrandr.so.2.2.0
b56ed000 b56ef000 r-xp /usr/lib/libXinerama.so.1.0.0
b5700000 b5703000 r-xp /usr/lib/libXfixes.so.3.1.0
b5713000 b571e000 r-xp /usr/lib/libXext.so.6.4.0
b572e000 b5730000 r-xp /usr/lib/libXdamage.so.1.1.0
b5740000 b5742000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5752000 b5834000 r-xp /usr/lib/libX11.so.6.3.0
b5848000 b584f000 r-xp /usr/lib/libXcursor.so.1.0.2
b585f000 b5877000 r-xp /usr/lib/libudev.so.1.6.0
b5879000 b587c000 r-xp /lib/libattr.so.1.1.0
b588c000 b58ac000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58ad000 b58b2000 r-xp /usr/lib/libffi.so.6.0.2
b58c3000 b58db000 r-xp /lib/libz.so.1.2.8
b58eb000 b58ed000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58fd000 b59d2000 r-xp /usr/lib/libxml2.so.2.9.2
b59e7000 b5a82000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a9e000 b5aa1000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ab1000 b5aca000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5adb000 b5aec000 r-xp /lib/libresolv-2.20-2014.11.so
b5b00000 b5b7a000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b8f000 b5b91000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5ba1000 b5ba8000 r-xp /usr/lib/libembryo.so.1.13.0
b5bb8000 b5bc2000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5bd3000 b5beb000 r-xp /usr/lib/libpng12.so.0.50.0
b5bfc000 b5c1f000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c40000 b5c54000 r-xp /usr/lib/libector.so.1.13.0
b5c65000 b5c7d000 r-xp /usr/lib/liblua-5.1.so
b5c8e000 b5ce5000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cf9000 b5d21000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d32000 b5d45000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d56000 b5d90000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5da1000 b5daf000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5dbf000 b5dc7000 r-xp /usr/lib/libtbm.so.1.0.0
b5dd7000 b5de4000 r-xp /usr/lib/libeio.so.1.13.0
b5df4000 b5df6000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e06000 b5e0b000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e1b000 b5e32000 r-xp /usr/lib/libefreet.so.1.13.0
b5e44000 b5e64000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e74000 b5e94000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e96000 b5e9c000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5eac000 b5ebd000 r-xp /usr/lib/libemotion.so.1.13.0
b5ece000 b5ed5000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ee5000 b5ef4000 r-xp /usr/lib/libeo.so.1.13.0
b5f05000 b5f17000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f28000 b5f2d000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f3d000 b5f56000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f66000 b5f83000 r-xp /usr/lib/libeet.so.1.13.0
b5f9c000 b5fe4000 r-xp /usr/lib/libeina.so.1.13.0
b5ff5000 b6005000 r-xp /usr/lib/libefl.so.1.13.0
b6016000 b60fb000 r-xp /usr/lib/libicuuc.so.51.1
b6118000 b6258000 r-xp /usr/lib/libicui18n.so.51.1
b626f000 b62a7000 r-xp /usr/lib/libecore_x.so.1.13.0
b62b9000 b62bc000 r-xp /lib/libcap.so.2.21
b62cc000 b62f5000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6306000 b630d000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b631f000 b6356000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6367000 b6452000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6465000 b64de000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64f0000 b64f5000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6505000 b650f000 r-xp /usr/lib/libvconf.so.0.2.45
b651f000 b6521000 r-xp /usr/lib/libvasum.so.0.3.1
b6531000 b6533000 r-xp /usr/lib/libttrace.so.1.1
b6543000 b6546000 r-xp /usr/lib/libiniparser.so.0
b6556000 b657c000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b658c000 b6591000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65a2000 b65b9000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65ca000 b6635000 r-xp /lib/libm-2.20-2014.11.so
b6646000 b664c000 r-xp /lib/librt-2.20-2014.11.so
b665d000 b666a000 r-xp /usr/lib/libunwind.so.8.0.1
b66a0000 b67c4000 r-xp /lib/libc-2.20-2014.11.so
b67d9000 b67f2000 r-xp /lib/libgcc_s-4.9.so.1
b6802000 b68e4000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68f5000 b691f000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6930000 b696c000 r-xp /usr/lib/libsystemd.so.0.4.0
b696e000 b69f1000 r-xp /usr/lib/libedje.so.1.13.0
b6a04000 b6a22000 r-xp /usr/lib/libecore.so.1.13.0
b6a42000 b6bc9000 r-xp /usr/lib/libevas.so.1.13.0
b6bfe000 b6c12000 r-xp /lib/libpthread-2.20-2014.11.so
b6c26000 b6e5a000 r-xp /usr/lib/libelementary.so.1.13.0
b6e89000 b6e8d000 r-xp /usr/lib/libsmack.so.1.0.0
b6e9d000 b6ea4000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6eb4000 b6eb6000 r-xp /usr/lib/libdlog.so.0.0.0
b6ec6000 b6ec9000 r-xp /usr/lib/libbundle.so.0.1.22
b6ed9000 b6edb000 r-xp /lib/libdl-2.20-2014.11.so
b6eec000 b6f04000 r-xp /usr/lib/libaul.so.0.1.0
b6f18000 b6f1d000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f2e000 b6f3b000 r-xp /usr/lib/liblptcp.so
b6f4d000 b6f51000 r-xp /usr/lib/libsys-assert.so
b6f62000 b6f82000 r-xp /lib/ld-2.20-2014.11.so
b6f93000 b6f98000 r-xp /usr/bin/launchpad-loader
b8c96000 b8f48000 rw-p [heap]
bedce000 bedef000 rw-p [stack]
b8c96000 b8f48000 rw-p [heap]
bedce000 bedef000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7813)
Call Stack Count: 21
 0: gengrid_it_cb + 0x1f (0xb2817950) [/opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1] + 0x1950
 1: (0xb6d140d5) [/usr/lib/libelementary.so.1] + 0xee0d5
 2: (0xb6d16533) [/usr/lib/libelementary.so.1] + 0xf0533
 3: (0xb6a77175) [/usr/lib/libevas.so.1] + 0x35175
 4: (0xb5ef0219) [/usr/lib/libeo.so.1] + 0xb219
 5: eo_event_callback_call + 0x68 (0xb5eeefb9) [/usr/lib/libeo.so.1] + 0x9fb9
 6: (0xb6a77515) [/usr/lib/libevas.so.1] + 0x35515
 7: (0xb6a775bf) [/usr/lib/libevas.so.1] + 0x355bf
 8: (0xb6a7fde7) [/usr/lib/libevas.so.1] + 0x3dde7
 9: evas_canvas_event_feed_mouse_up + 0x6a (0xb6a84ea7) [/usr/lib/libevas.so.1] + 0x42ea7
10: evas_event_feed_mouse_up + 0x30 (0xb6a888e9) [/usr/lib/libevas.so.1] + 0x468e9
11: (0xb46cf1cb) [/usr/lib/libecore_input_evas.so.1] + 0x21cb
12: (0xb6a0fc4b) [/usr/lib/libecore.so.1] + 0xbc4b
13: (0xb6a15a5d) [/usr/lib/libecore.so.1] + 0x11a5d
14: ecore_main_loop_begin + 0x3e (0xb6a15c83) [/usr/lib/libecore.so.1] + 0x11c83
15: appcore_efl_main + 0x20c (0xb6f1b2bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
16: ui_app_main + 0xc0 (0xb3fd1909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
17: main + 0x122 (0xb2817373) [/opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1] + 0x1373
18: (0xb6f94bb5) [/opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1] + 0x1bb5
19: __libc_start_main + 0x114 (0xb66b64bc) [/lib/libc.so.6] + 0x164bc
20: (0xb6f94eb4) [/opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1] + 0x1eb4
End of Call Stack

Package Information
Package Name: org.example.basicgalleryex1
Package ID : org.example.basicgalleryex1
Version: 1.0.0
Package Type: tpk
App Name: basicgalleryex1
App ID: org.example.basicgalleryex1
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
orymanager.service provider is found.
09-08 12:35:19.263+0900 I/Tizen::System( 1250): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 7552, ]
09-08 12:35:19.263+0900 I/Tizen::System( 1250): (256) > osp.system.service provider is found.
09-08 12:35:19.263+0900 I/Tizen::App( 1250): (506) > TerminatedApp(com.samsung.weather-m-agent)
09-08 12:35:19.263+0900 I/Tizen::App( 1250): (512) > Not registered pid(7552)
09-08 12:35:19.263+0900 I/Tizen::System( 1250): (246) > Terminated app [com.samsung.weather-m-agent]
09-08 12:35:19.263+0900 I/Tizen::Io( 1250): (729) > Entry not found
09-08 12:35:19.263+0900 I/ESD     (  880): esd_main.c: __esd_app_dead_handler(1773) > pid: 7552
09-08 12:35:19.273+0900 I/Tizen::System( 1250): (157) > change brightness system value.
09-08 12:35:19.273+0900 I/Tizen::App( 1250): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 7552.
09-08 12:35:23.808+0900 I/APP_CORE(  842): appcore-efl.c: __do_app(514) > [APP 842] Event: MEM_FLUSH State: PAUSED
09-08 12:35:24.128+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-08 12:35:27.922+0900 E/PKGMGR_SERVER( 7593): pkgmgr-server.c: main(2414) > package manager server start
09-08 12:35:27.972+0900 E/PKGMGR_SERVER( 7593): pkgmgr-server.c: __set_recovery_mode(234) > rev_file[/opt/share/packages/.recovery/pkgmgr/org.example.basicgalleryex1] is null
09-08 12:35:27.982+0900 E/PKGMGR  ( 7591): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.basicgalleryex1, -1]
09-08 12:35:28.012+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
09-08 12:35:28.012+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 7267
09-08 12:35:28.012+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 12
09-08 12:35:28.012+0900 W/AUL     ( 7596): launch.c: app_request_to_launchpad(396) > request cmd(5) to(7267)
09-08 12:35:28.022+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
09-08 12:35:28.022+0900 I/APP_CORE( 7267): appcore-efl.c: __do_app(514) > [APP 7267] Event: TERMINATE State: PAUSED
09-08 12:35:28.022+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(7267), cmd(4)
09-08 12:35:28.022+0900 W/AUL     ( 7596): launch.c: app_request_to_launchpad(425) > request cmd(5) result(0)
09-08 12:35:28.022+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
09-08 12:35:28.022+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
09-08 12:35:28.022+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
09-08 12:35:28.022+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
09-08 12:35:28.022+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
09-08 12:35:28.022+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
09-08 12:35:28.032+0900 E/PKGMGR_SERVER( 7593): pkgmgr-server.c: __unset_recovery_mode(282) > remove recovery_file[/opt/share/packages/.recovery/pkgmgr/org.example.basicgalleryex1] fail
09-08 12:35:28.032+0900 E/PKGMGR_SERVER( 7593): pkgmgr-server.c: sighandler(417) > child NORMAL exit [7596]
09-08 12:35:28.032+0900 I/TIZEN_N_EFL_UTIL_WINDOW( 7267): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 12
09-08 12:35:28.032+0900 E/APP_CORE( 7267): appcore-efl.c: _capture_and_make_file(1619) > win[6200002] widget[720] height[1280]
09-08 12:35:28.032+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 33
09-08 12:35:28.032+0900 E/APP_CORE( 7267): appcore-efl.c: _capture_and_make_file(1622) > cannot a capture file for the package of [org.example.basicgalleryex1]
09-08 12:35:28.042+0900 I/CAPI_APPFW_APPLICATION( 7267): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-08 12:35:28.252+0900 E/VCONF   ( 7267): vconf-kdb.c: _vconf_kdb_del_notify(468) > Error: inotify_add_watch() [/opt/var/kdb/db/ise+keysound]: Permission denied
09-08 12:35:28.252+0900 E/VCONF   ( 7267): vconf.c: vconf_ignore_key_changed(3218) > vconf_ignore_key_changed() failed: key(db/ise/keysound)
09-08 12:35:28.282+0900 I/AUL_PAD ( 1491): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 7267 pgid = 7267
09-08 12:35:28.282+0900 I/AUL_PAD ( 1491): sigchild.h: __sigchild_action(143) > dead_pid(7267)
09-08 12:35:28.312+0900 I/AUL_PAD ( 1491): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-08 12:35:28.312+0900 I/AUL_PAD ( 1491): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-08 12:35:28.312+0900 E/AUL_PAD ( 1491): launchpad.c: main(698) > error reading sigchld info
09-08 12:35:28.312+0900 I/Tizen::App( 1250): (243) > App[org.example.basicgalleryex1] pid[7267] terminate event is forwarded
09-08 12:35:28.312+0900 I/Tizen::System( 1250): (256) > osp.accessorymanager.service provider is found.
09-08 12:35:28.312+0900 I/Tizen::System( 1250): (196) > Accessory Owner is removed [org.example.basicgalleryex1, 7267, ]
09-08 12:35:28.312+0900 I/Tizen::System( 1250): (256) > osp.system.service provider is found.
09-08 12:35:28.312+0900 I/Tizen::App( 1250): (506) > TerminatedApp(org.example.basicgalleryex1)
09-08 12:35:28.312+0900 I/Tizen::App( 1250): (512) > Not registered pid(7267)
09-08 12:35:28.312+0900 I/Tizen::System( 1250): (246) > Terminated app [org.example.basicgalleryex1]
09-08 12:35:28.312+0900 I/Tizen::Io( 1250): (729) > Entry not found
09-08 12:35:28.312+0900 I/ESD     (  880): esd_main.c: __esd_app_dead_handler(1773) > pid: 7267
09-08 12:35:28.312+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 7267
09-08 12:35:28.322+0900 E/RESOURCED(  671): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.836
09-08 12:35:28.332+0900 I/Tizen::System( 1250): (157) > change brightness system value.
09-08 12:35:28.332+0900 I/Tizen::App( 1250): (782) > Finished invoking application event listener for org.example.basicgalleryex1, 7267.
09-08 12:35:28.532+0900 E/AUL_AMD (  610): amd_launch.c: _amd_proc_find_proc_info(1914) > proc info not found
09-08 12:35:30.604+0900 E/PKGMGR_SERVER( 7593): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
09-08 12:35:30.604+0900 E/PKGMGR_SERVER( 7593): pkgmgr-server.c: main(2471) > package manager server terminated.
09-08 12:35:33.027+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-08 12:35:33.027+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-08 12:35:34.308+0900 E/PKGMGR  ( 7684): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
09-08 12:35:34.388+0900 E/PKGMGR_SERVER( 7686): pkgmgr-server.c: main(2414) > package manager server start
09-08 12:35:34.438+0900 E/PKGMGR_SERVER( 7686): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.basicgalleryex1]
09-08 12:35:34.448+0900 E/PKGMGR_SERVER( 7686): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.basicgalleryex1 errno: 2 (No such file or directory)[0;m
09-08 12:35:34.448+0900 E/PKGMGR_SERVER( 7686): pkgmgr-server.c: __set_recovery_mode(234) > rev_file[/opt/share/packages/.recovery/pkgmgr/org.example.basicgalleryex1] is null
09-08 12:35:34.448+0900 E/PKGMGR  ( 7684): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[76840002]
09-08 12:35:34.608+0900 I/Tizen::App( 1250): (1894) > PackageEventHandler - req: 12500002, pkg_type: tpk, pkg_name: org.example.basicgalleryex1, key: start, val: update
09-08 12:35:34.608+0900 I/Tizen::App( 1250): (1584) > Package = [org.example.basicgalleryex1], Key = [start], Value = [update], install = [1]
09-08 12:35:34.608+0900 E/PKGMGR  ( 1551): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-08 12:35:34.608+0900 E/PKGMGR  ( 1551): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-08 12:35:34.608+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
09-08 12:35:34.618+0900 I/Tizen::App( 1250): (1894) > PackageEventHandler - req: 12500002, pkg_type: tpk, pkg_name: org.example.basicgalleryex1, key: install_percent, val: 30
09-08 12:35:34.618+0900 I/Tizen::App( 1250): (119) > InstallationInProgress [30]
09-08 12:35:34.618+0900 I/Tizen::App( 1250): (1584) > Package = [org.example.basicgalleryex1], Key = [install_percent], Value = [30], install = [1]
09-08 12:35:34.618+0900 E/PKGMGR  ( 1551): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-08 12:35:34.618+0900 E/PKGMGR  ( 1551): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-08 12:35:34.909+0900 W/CERT_SVC_VCORE( 7689): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
09-08 12:35:35.139+0900 E/rpm-installer( 7689): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
09-08 12:35:35.139+0900 E/rpm-installer( 7689): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
09-08 12:35:35.189+0900 E/PKGMGR_PARSER( 7689): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
09-08 12:35:35.209+0900 E/PKGMGR_CERT( 7689): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
09-08 12:35:35.209+0900 E/PKGMGR_CERT( 7689): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
09-08 12:35:35.219+0900 E/PKGMGR_CERT( 7689): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
09-08 12:35:35.249+0900 E/rpm-installer( 7689): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.basicgalleryex1) failed.
09-08 12:35:35.259+0900 E/PKGMGR  ( 1551): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-08 12:35:35.259+0900 E/PKGMGR  ( 1551): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-08 12:35:35.259+0900 I/Tizen::App( 1250): (1894) > PackageEventHandler - req: 12500002, pkg_type: tpk, pkg_name: org.example.basicgalleryex1, key: end, val: fail
09-08 12:35:35.259+0900 I/Tizen::App( 1250): (1584) > Package = [org.example.basicgalleryex1], Key = [end], Value = [fail], install = [1]
09-08 12:35:35.259+0900 E/ESD     (  880): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
09-08 12:35:35.269+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
09-08 12:35:35.269+0900 W/ISF_PANEL_EFL(  778): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.basicgalleryex1",~) returned -1
09-08 12:35:35.269+0900 W/ISF_PANEL_EFL(  778): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
09-08 12:35:36.600+0900 E/PKGMGR_SERVER( 7686): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
09-08 12:35:37.161+0900 E/PKGMGR_SERVER( 7686): pkgmgr-server.c: __unset_recovery_mode(282) > remove recovery_file[/opt/share/packages/.recovery/pkgmgr/org.example.basicgalleryex1] fail
09-08 12:35:37.161+0900 E/PKGMGR_SERVER( 7686): pkgmgr-server.c: sighandler(417) > child NORMAL exit [7689]
09-08 12:35:38.602+0900 E/PKGMGR_SERVER( 7686): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
09-08 12:35:38.602+0900 E/PKGMGR_SERVER( 7686): pkgmgr-server.c: main(2471) > package manager server terminated.
09-08 12:35:41.205+0900 E/PKGMGR  ( 7739): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
09-08 12:35:41.285+0900 E/PKGMGR_SERVER( 7741): pkgmgr-server.c: main(2414) > package manager server start
09-08 12:35:41.335+0900 E/PKGMGR_SERVER( 7741): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.basicgalleryex1-1.0.0-arm.tpk]
09-08 12:35:41.345+0900 E/PKGMGR_INFO( 7741): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.basicgalleryex1-1.0.0-arm.tpk] not found in DB
09-08 12:35:41.345+0900 E/rpm-installer( 7741): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
09-08 12:35:41.355+0900 E/PKGMGR_SERVER( 7741): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
09-08 12:35:41.365+0900 E/PKGMGR_SERVER( 7741): pkgmgr-server.c: __set_recovery_mode(234) > rev_file[/opt/share/packages/.recovery/pkgmgr/org.example.basicgalleryex1-1.0.0-arm.tpk] is null
09-08 12:35:41.365+0900 E/PKGMGR  ( 7739): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[77390002]
09-08 12:35:41.485+0900 E/PKGMGR_INSTALLER( 7744): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
09-08 12:35:41.485+0900 E/rpm-installer( 7744): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.basicgalleryex1-1.0.0-arm.tpk] is tpk package.
09-08 12:35:41.495+0900 E/rpm-installer( 7744): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
09-08 12:35:41.495+0900 E/rpm-installer( 7744): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
09-08 12:35:41.495+0900 E/rpm-installer( 7744): coretpk-parser.c: __coretpk_parser_get_value_list(1104) > (ret == 1) [//*[name() ='privileges']/*[name()='privilege']] is empty.
09-08 12:35:41.495+0900 E/rpm-installer( 7744): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
09-08 12:35:41.505+0900 E/rpm-installer( 7744): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
09-08 12:35:41.505+0900 E/rpm-installer( 7744): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
09-08 12:35:41.555+0900 W/CERT_SVC_VCORE( 7744): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
09-08 12:35:41.605+0900 E/PKGMGR  ( 1551): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-08 12:35:41.605+0900 E/PKGMGR  ( 1551): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-08 12:35:41.615+0900 I/Tizen::App( 1250): (1894) > PackageEventHandler - req: 12500002, pkg_type: tpk, pkg_name: org.example.basicgalleryex1, key: start, val: install
09-08 12:35:41.615+0900 I/Tizen::App( 1250): (1584) > Package = [org.example.basicgalleryex1], Key = [start], Value = [install], install = [1]
09-08 12:35:41.615+0900 I/Tizen::App( 1250): (1894) > PackageEventHandler - req: 12500002, pkg_type: tpk, pkg_name: org.example.basicgalleryex1, key: install_percent, val: 30
09-08 12:35:41.615+0900 I/Tizen::App( 1250): (119) > InstallationInProgress [30]
09-08 12:35:41.615+0900 I/Tizen::App( 1250): (1584) > Package = [org.example.basicgalleryex1], Key = [install_percent], Value = [30], install = [1]
09-08 12:35:41.615+0900 E/PKGMGR  ( 1551): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-08 12:35:41.615+0900 E/PKGMGR  ( 1551): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-08 12:35:42.236+0900 E/rpm-installer( 7744): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
09-08 12:35:42.236+0900 E/rpm-installer( 7744): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
09-08 12:35:42.236+0900 E/rpm-installer( 7744): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
09-08 12:35:42.236+0900 E/rpm-installer( 7744): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
09-08 12:35:42.236+0900 E/rpm-installer( 7744): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
09-08 12:35:42.236+0900 E/rpm-installer( 7744): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
09-08 12:35:42.246+0900 E/PKGMGR_PARSER( 7744): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
09-08 12:35:42.246+0900 E/PKGMGR_PARSER( 7744): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
09-08 12:35:42.476+0900 E/PKGMGR_PARSER( 7744): pkgmgr_parser.c: __check_theme(142) > theme for installation.
09-08 12:35:42.496+0900 E/PKGMGR_CERT( 7744): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
09-08 12:35:42.496+0900 E/PKGMGR_CERT( 7744): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 121
09-08 12:35:42.496+0900 E/PKGMGR_CERT( 7744): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 121
09-08 12:35:42.496+0900 E/PKGMGR_CERT( 7744): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 40 12
09-08 12:35:42.496+0900 E/PKGMGR_CERT( 7744): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 37 14
09-08 12:35:42.496+0900 E/PKGMGR_CERT( 7744): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 38 14
09-08 12:35:42.496+0900 E/PKGMGR_CERT( 7744): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 12
09-08 12:35:42.506+0900 E/PKGMGR_CERT( 7744): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
09-08 12:35:42.516+0900 E/PKGMGR  ( 1551): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-08 12:35:42.516+0900 I/Tizen::App( 1250): (1894) > PackageEventHandler - req: 12500002, pkg_type: tpk, pkg_name: org.example.basicgalleryex1, key: install_percent, val: 60
09-08 12:35:42.516+0900 E/PKGMGR  ( 1551): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-08 12:35:42.516+0900 I/Tizen::App( 1250): (119) > InstallationInProgress [60]
09-08 12:35:42.516+0900 I/Tizen::App( 1250): (1584) > Package = [org.example.basicgalleryex1], Key = [install_percent], Value = [60], install = [1]
09-08 12:35:42.526+0900 E/rpm-installer( 7744): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
09-08 12:35:42.556+0900 E/rpm-installer( 7744): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
09-08 12:35:42.556+0900 I/Tizen::App( 1250): (1894) > PackageEventHandler - req: 12500002, pkg_type: tpk, pkg_name: org.example.basicgalleryex1, key: install_percent, val: 100
09-08 12:35:42.556+0900 I/Tizen::App( 1250): (119) > InstallationInProgress [100]
09-08 12:35:42.556+0900 I/Tizen::App( 1250): (1584) > Package = [org.example.basicgalleryex1], Key = [install_percent], Value = [100], install = [1]
09-08 12:35:42.556+0900 E/PKGMGR  ( 1551): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-08 12:35:42.556+0900 E/PKGMGR  ( 1551): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-08 12:35:43.607+0900 E/PKGMGR_SERVER( 7741): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
09-08 12:35:44.788+0900 I/Tizen::App( 1250): (1894) > PackageEventHandler - req: 12500002, pkg_type: tpk, pkg_name: org.example.basicgalleryex1, key: end, val: ok
09-08 12:35:44.788+0900 I/Tizen::App( 1250): (78) > Installation is Completed. [Package = org.example.basicgalleryex1]
09-08 12:35:44.788+0900 I/Tizen::App( 1250): (671) > Enter. package(org.example.basicgalleryex1), installationResult(0)
09-08 12:35:44.788+0900 E/PKGMGR  ( 1551): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-08 12:35:44.788+0900 E/PKGMGR  ( 1551): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-08 12:35:44.798+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
09-08 12:35:44.798+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
09-08 12:35:44.798+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
09-08 12:35:44.828+0900 E/PKGMGR_SERVER( 7741): pkgmgr-server.c: __unset_recovery_mode(282) > remove recovery_file[/opt/share/packages/.recovery/pkgmgr/org.example.basicgalleryex1-1.0.0-arm.tpk] fail
09-08 12:35:44.828+0900 E/PKGMGR_SERVER( 7741): pkgmgr-server.c: sighandler(417) > child NORMAL exit [7744]
09-08 12:35:44.838+0900 W/ISF_PANEL_EFL(  778): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
09-08 12:35:44.838+0900 I/Tizen::App( 1250): (1360) > package(org.example.basicgalleryex1), version(1.0.0), type(tpk), displayName(basicgalleryex1), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.basicgalleryex1), storeClient(), appRootPath(/opt/usr/apps/org.example.basicgalleryex1)
09-08 12:35:44.858+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.basicgalleryex1]
09-08 12:35:44.858+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.basicgalleryex1]
09-08 12:35:44.858+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
09-08 12:35:44.858+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
09-08 12:35:44.858+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.basicgalleryex1]
09-08 12:35:44.858+0900 I/Tizen::App( 1250): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.basicgalleryex1]
09-08 12:35:44.868+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[basicgalleryex1] enable[1] system[0]
09-08 12:35:44.868+0900 E/HOME_APPS(  860): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.basicgalleryex1] mdm is not enabled
09-08 12:35:44.868+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[basicgalleryex1] enable[1] system[0]
09-08 12:35:44.868+0900 W/HOME_APPS(  860): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.basicgalleryex1/shared/res/basicgalleryex1.png], New icon path[/opt/usr/apps/org.example.basicgalleryex1/shared/res/basicgalleryex1.png]!!!!!
09-08 12:35:44.878+0900 I/Tizen::App( 1250): (416) > appName = [basicgalleryex1]
09-08 12:35:44.878+0900 I/Tizen::App( 1250): (509) > exe = [/opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1], displayName = [basicgalleryex1], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
09-08 12:35:44.878+0900 E/PKGMGR_INFO( 1250): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
09-08 12:35:44.878+0900 I/Tizen::App( 1250): (683) > Application count(1) in this package
09-08 12:35:44.878+0900 I/Tizen::App( 1250): (840) > Enter.
09-08 12:35:44.878+0900 I/Tizen::App( 1250): (703) > Exit.
09-08 12:35:44.878+0900 I/Tizen::App( 1250): (1584) > Package = [org.example.basicgalleryex1], Key = [end], Value = [ok], install = [1]
09-08 12:35:44.888+0900 E/util-view(  860): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
09-08 12:35:44.888+0900 I/Tizen::App( 1250): (416) > appName = [basicgalleryex1]
09-08 12:35:44.888+0900 I/Tizen::App( 1250): (509) > exe = [/opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1], displayName = [basicgalleryex1], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
09-08 12:35:44.888+0900 I/Tizen::App( 1250): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.basicgalleryex1.info]
09-08 12:35:44.888+0900 I/Tizen::App( 1250): (131) > Enter
09-08 12:35:44.888+0900 I/Tizen::App( 1250): (137) > org.example.basicgalleryex1 does not have launch condition
09-08 12:35:44.888+0900 I/Tizen::App( 1250): (883) > Exit.
09-08 12:35:44.908+0900 W/HOME_APPS(  860): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.basicgalleryex1/shared/res/basicgalleryex1.png], Loading state:[1]
09-08 12:35:45.599+0900 E/PKGMGR_SERVER( 7741): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
09-08 12:35:45.599+0900 E/PKGMGR_SERVER( 7741): pkgmgr-server.c: main(2471) > package manager server terminated.
09-08 12:35:50.504+0900 W/AUL     ( 7800): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.basicgalleryex1)
09-08 12:35:50.504+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
09-08 12:35:50.514+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
09-08 12:35:50.514+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
09-08 12:35:50.514+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
09-08 12:35:50.514+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 7800
09-08 12:35:50.514+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
09-08 12:35:50.524+0900 E/RESOURCED(  671): block.c: block_prelaunch_state(134) > insert data org.example.basicgalleryex1, table num : 8
09-08 12:35:50.524+0900 E/RESOURCED(  671): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-08 12:35:50.534+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
09-08 12:35:50.534+0900 W/AUL_PAD ( 1491): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
09-08 12:35:50.534+0900 W/AUL_PAD ( 1491): launchpad.c: __send_result_to_caller(267) > Check app launching
09-08 12:35:50.554+0900 I/CAPI_APPFW_APPLICATION( 7528): app_main.c: ui_app_main(789) > app_efl_main
09-08 12:35:50.554+0900 I/CAPI_APPFW_APPLICATION( 7528): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
09-08 12:35:50.584+0900 E/TBM     ( 7528): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
09-08 12:35:50.634+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 7528, appid: org.example.basicgalleryex1
09-08 12:35:50.634+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
09-08 12:35:50.634+0900 E/RESOURCED(  671): proc-main.c: proc_add_program_list(237) > not found ppi : org.example.basicgalleryex1
09-08 12:35:50.644+0900 W/AUL     ( 7800): launch.c: app_request_to_launchpad(425) > request cmd(0) result(7528)
09-08 12:35:50.714+0900 I/APP_CORE( 7528): appcore-efl.c: __do_app(514) > [APP 7528] Event: RESET State: CREATED
09-08 12:35:50.714+0900 I/CAPI_APPFW_APPLICATION( 7528): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
09-08 12:35:50.714+0900 E/EFL     ( 7528): edje<7528> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-08 12:35:50.714+0900 E/EFL     ( 7528): By the power of Grayskull, your previous Embryo stack is now broken!
09-08 12:35:50.714+0900 E/EFL     ( 7528): edje<7528> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-08 12:35:50.714+0900 E/EFL     ( 7528): By the power of Grayskull, your previous Embryo stack is now broken!
09-08 12:35:50.714+0900 E/EFL     ( 7528): edje<7528> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-08 12:35:50.714+0900 E/EFL     ( 7528): By the power of Grayskull, your previous Embryo stack is now broken!
09-08 12:35:50.714+0900 E/EFL     ( 7528): edje<7528> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-08 12:35:50.714+0900 E/EFL     ( 7528): By the power of Grayskull, your previous Embryo stack is now broken!
09-08 12:35:50.714+0900 E/EFL     ( 7528): edje<7528> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-08 12:35:50.714+0900 E/EFL     ( 7528): By the power of Grayskull, your previous Embryo stack is now broken!
09-08 12:35:50.744+0900 W/APP_CORE( 7528): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6000002
09-08 12:35:50.744+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
09-08 12:35:50.754+0900 E/EFL     (  330): eo<330> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-08 12:35:50.754+0900 E/EFL     (  330): eo<330> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-08 12:35:50.774+0900 I/Tizen::System( 1250): (259) > Active app [org.exampl], current [com.samsun] 
09-08 12:35:50.774+0900 I/Tizen::Io( 1250): (729) > Entry not found
09-08 12:35:50.774+0900 I/Tizen::System( 1250): (157) > change brightness system value.
09-08 12:35:50.784+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
09-08 12:35:50.864+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
09-08 12:35:50.864+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-08 12:35:50.864+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
09-08 12:35:50.864+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
09-08 12:35:50.864+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
09-08 12:35:50.864+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
09-08 12:35:50.864+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7528) status(3)
09-08 12:35:50.864+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-08 12:35:50.864+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
09-08 12:35:50.864+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.basicgalleryex1(7528)
09-08 12:35:50.864+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 7528, appid: org.example.basicgalleryex1, status: fg
09-08 12:35:50.894+0900 I/APP_CORE( 7528): appcore-efl.c: __do_app(514) > [APP 7528] Event: RESUME State: CREATED
09-08 12:35:50.904+0900 I/APP_CORE( 7528): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
09-08 12:35:50.904+0900 I/APP_CORE( 7528): appcore-efl.c: __do_app(625) > [APP 7528] Initial Launching, call the resume_cb
09-08 12:35:50.904+0900 I/CAPI_APPFW_APPLICATION( 7528): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-08 12:35:51.234+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7528) status(0)
09-08 12:35:51.705+0900 E/RESOURCED(  671): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.846
09-08 12:35:51.705+0900 I/Tizen::App( 1250): (499) > LaunchedApp(org.example.basicgalleryex1)
09-08 12:35:51.705+0900 I/Tizen::App( 1250): (733) > Finished invoking application event listener for org.example.basicgalleryex1, 7528.
09-08 12:35:52.406+0900 E/EFL     ( 7528): ecore_x<7528> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=4230807
09-08 12:35:52.466+0900 E/EFL     ( 7528): ecore_x<7528> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=4230862
09-08 12:35:52.506+0900 I/UXT     ( 7813): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
09-08 12:35:52.616+0900 I/AUL_PAD ( 1491): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 7528 pgid = 7528
09-08 12:35:52.616+0900 I/AUL_PAD ( 1491): sigchild.h: __sigchild_action(143) > dead_pid(7528)
09-08 12:35:52.616+0900 E/EFL     (  330): eo<330> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-08 12:35:52.626+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
09-08 12:35:52.626+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-08 12:35:52.626+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
09-08 12:35:52.626+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
09-08 12:35:52.626+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
09-08 12:35:52.666+0900 I/AUL_PAD ( 1491): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-08 12:35:52.666+0900 I/AUL_PAD ( 1491): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-08 12:35:52.666+0900 E/AUL_PAD ( 1491): launchpad.c: main(698) > error reading sigchld info
09-08 12:35:52.666+0900 I/Tizen::App( 1250): (243) > App[org.example.basicgalleryex1] pid[7528] terminate event is forwarded
09-08 12:35:52.666+0900 I/Tizen::System( 1250): (256) > osp.accessorymanager.service provider is found.
09-08 12:35:52.666+0900 I/Tizen::System( 1250): (196) > Accessory Owner is removed [org.example.basicgalleryex1, 7528, ]
09-08 12:35:52.666+0900 I/Tizen::System( 1250): (256) > osp.system.service provider is found.
09-08 12:35:52.666+0900 I/Tizen::App( 1250): (506) > TerminatedApp(org.example.basicgalleryex1)
09-08 12:35:52.666+0900 I/Tizen::App( 1250): (512) > Not registered pid(7528)
09-08 12:35:52.666+0900 I/Tizen::System( 1250): (246) > Terminated app [org.example.basicgalleryex1]
09-08 12:35:52.666+0900 I/Tizen::Io( 1250): (729) > Entry not found
09-08 12:35:52.676+0900 I/ESD     (  880): esd_main.c: __esd_app_dead_handler(1773) > pid: 7528
09-08 12:35:52.676+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 7528
09-08 12:35:52.676+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 7528
09-08 12:35:52.686+0900 E/RESOURCED(  671): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.849
09-08 12:35:52.696+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
09-08 12:35:52.696+0900 I/Tizen::System( 1250): (157) > change brightness system value.
09-08 12:35:52.696+0900 I/Tizen::App( 1250): (782) > Finished invoking application event listener for org.example.basicgalleryex1, 7528.
09-08 12:35:52.706+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
09-08 12:35:52.706+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-08 12:35:52.706+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
09-08 12:35:52.706+0900 E/EFL     (  330): eo<330> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-08 12:35:52.726+0900 I/Tizen::System( 1250): (259) > Active app [com.samsun], current [org.exampl] 
09-08 12:35:52.726+0900 I/Tizen::Io( 1250): (729) > Entry not found
09-08 12:35:52.766+0900 W/CRASH_MANAGER( 7820): worker.c: worker_job(1199) > 11075286261731473305752
09-08 12:35:52.766+0900 I/TIZEN_N_SOUND_MANAGER(  900): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=8, ret=0x0
09-08 12:35:52.766+0900 E/TIZEN_N_SOUND_MANAGER(  900): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-08 12:35:52.766+0900 I/TIZEN_N_SOUND_MANAGER(  900): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=4, ret=0x0
09-08 12:35:52.766+0900 E/TIZEN_N_SOUND_MANAGER(  900): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-08 12:35:52.776+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
09-08 12:35:52.806+0900 I/Tizen::System( 1250): (157) > change brightness system value.
09-08 12:35:56.560+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=4234960
09-08 12:35:56.640+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=4235048
09-08 12:35:56.650+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.basicgalleryex1)
09-08 12:35:56.650+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
09-08 12:35:56.650+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 860
09-08 12:35:56.660+0900 E/RESOURCED(  671): block.c: block_prelaunch_state(134) > insert data org.example.basicgalleryex1, table num : 8
09-08 12:35:56.660+0900 E/RESOURCED(  671): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-08 12:35:56.660+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
09-08 12:35:56.660+0900 W/AUL_PAD ( 1491): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
09-08 12:35:56.660+0900 W/AUL_PAD ( 1491): launchpad.c: __send_result_to_caller(267) > Check app launching
09-08 12:35:56.680+0900 I/CAPI_APPFW_APPLICATION( 7813): app_main.c: ui_app_main(789) > app_efl_main
09-08 12:35:56.680+0900 I/CAPI_APPFW_APPLICATION( 7813): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
09-08 12:35:56.710+0900 E/TBM     ( 7813): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
09-08 12:35:56.760+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 7813, appid: org.example.basicgalleryex1
09-08 12:35:56.760+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
09-08 12:35:56.770+0900 E/RESOURCED(  671): proc-main.c: proc_add_program_list(237) > not found ppi : org.example.basicgalleryex1
09-08 12:35:56.780+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(425) > request cmd(1) result(7813)
09-08 12:35:56.850+0900 I/APP_CORE( 7813): appcore-efl.c: __do_app(514) > [APP 7813] Event: RESET State: CREATED
09-08 12:35:56.850+0900 I/CAPI_APPFW_APPLICATION( 7813): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
09-08 12:35:56.850+0900 E/EFL     ( 7813): edje<7813> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-08 12:35:56.850+0900 E/EFL     ( 7813): By the power of Grayskull, your previous Embryo stack is now broken!
09-08 12:35:56.860+0900 E/EFL     ( 7813): edje<7813> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-08 12:35:56.860+0900 E/EFL     ( 7813): By the power of Grayskull, your previous Embryo stack is now broken!
09-08 12:35:56.860+0900 E/EFL     ( 7813): edje<7813> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-08 12:35:56.860+0900 E/EFL     ( 7813): By the power of Grayskull, your previous Embryo stack is now broken!
09-08 12:35:56.860+0900 E/EFL     ( 7813): edje<7813> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-08 12:35:56.860+0900 E/EFL     ( 7813): By the power of Grayskull, your previous Embryo stack is now broken!
09-08 12:35:56.860+0900 E/EFL     ( 7813): edje<7813> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-08 12:35:56.860+0900 E/EFL     ( 7813): By the power of Grayskull, your previous Embryo stack is now broken!
09-08 12:35:56.880+0900 W/APP_CORE( 7813): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6200002
09-08 12:35:56.880+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
09-08 12:35:56.890+0900 E/EFL     (  330): eo<330> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-08 12:35:56.890+0900 E/EFL     (  330): eo<330> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-08 12:35:56.920+0900 I/Tizen::System( 1250): (259) > Active app [org.exampl], current [com.samsun] 
09-08 12:35:56.920+0900 I/Tizen::Io( 1250): (729) > Entry not found
09-08 12:35:56.930+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
09-08 12:35:56.930+0900 I/Tizen::System( 1250): (157) > change brightness system value.
09-08 12:35:57.020+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
09-08 12:35:57.020+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-08 12:35:57.020+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
09-08 12:35:57.020+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
09-08 12:35:57.020+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
09-08 12:35:57.020+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
09-08 12:35:57.030+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7813) status(3)
09-08 12:35:57.030+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.basicgalleryex1(7813)
09-08 12:35:57.030+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 7813, appid: org.example.basicgalleryex1, status: fg
09-08 12:35:57.050+0900 I/APP_CORE( 7813): appcore-efl.c: __do_app(514) > [APP 7813] Event: RESUME State: CREATED
09-08 12:35:57.060+0900 I/APP_CORE( 7813): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
09-08 12:35:57.060+0900 I/APP_CORE( 7813): appcore-efl.c: __do_app(625) > [APP 7813] Initial Launching, call the resume_cb
09-08 12:35:57.060+0900 I/CAPI_APPFW_APPLICATION( 7813): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-08 12:35:57.390+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7813) status(0)
09-08 12:35:57.801+0900 I/Tizen::App( 1250): (499) > LaunchedApp(org.example.basicgalleryex1)
09-08 12:35:57.801+0900 I/Tizen::App( 1250): (733) > Finished invoking application event listener for org.example.basicgalleryex1, 7813.
09-08 12:35:57.811+0900 E/RESOURCED(  671): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.851
09-08 12:35:58.662+0900 I/UXT     ( 7848): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
09-08 12:35:58.932+0900 E/EFL     ( 7813): ecore_x<7813> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=4237334
09-08 12:35:59.002+0900 E/EFL     ( 7813): ecore_x<7813> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=4237400
09-08 12:35:59.142+0900 I/AUL_PAD ( 1491): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 7813 pgid = 7813
09-08 12:35:59.142+0900 I/AUL_PAD ( 1491): sigchild.h: __sigchild_action(143) > dead_pid(7813)
09-08 12:35:59.142+0900 E/EFL     (  330): eo<330> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-08 12:35:59.152+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
09-08 12:35:59.152+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-08 12:35:59.152+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
09-08 12:35:59.152+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
09-08 12:35:59.152+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
09-08 12:35:59.192+0900 I/AUL_PAD ( 1491): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-08 12:35:59.192+0900 I/AUL_PAD ( 1491): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-08 12:35:59.192+0900 E/AUL_PAD ( 1491): launchpad.c: main(698) > error reading sigchld info
09-08 12:35:59.192+0900 I/Tizen::App( 1250): (243) > App[org.example.basicgalleryex1] pid[7813] terminate event is forwarded
09-08 12:35:59.192+0900 I/Tizen::System( 1250): (256) > osp.accessorymanager.service provider is found.
09-08 12:35:59.192+0900 I/Tizen::System( 1250): (196) > Accessory Owner is removed [org.example.basicgalleryex1, 7813, ]
09-08 12:35:59.192+0900 I/Tizen::System( 1250): (256) > osp.system.service provider is found.
09-08 12:35:59.192+0900 I/Tizen::App( 1250): (506) > TerminatedApp(org.example.basicgalleryex1)
09-08 12:35:59.192+0900 I/Tizen::App( 1250): (512) > Not registered pid(7813)
09-08 12:35:59.192+0900 I/Tizen::System( 1250): (246) > Terminated app [org.example.basicgalleryex1]
09-08 12:35:59.192+0900 I/Tizen::Io( 1250): (729) > Entry not found
09-08 12:35:59.192+0900 I/ESD     (  880): esd_main.c: __esd_app_dead_handler(1773) > pid: 7813
09-08 12:35:59.202+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 7813
09-08 12:35:59.202+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 7813
09-08 12:35:59.212+0900 E/RESOURCED(  671): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.854
09-08 12:35:59.212+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
09-08 12:35:59.222+0900 I/Tizen::System( 1250): (157) > change brightness system value.
09-08 12:35:59.222+0900 I/Tizen::App( 1250): (782) > Finished invoking application event listener for org.example.basicgalleryex1, 7813.
09-08 12:35:59.232+0900 E/EFL     (  330): eo<330> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-08 12:35:59.232+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
09-08 12:35:59.232+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-08 12:35:59.232+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
09-08 12:35:59.262+0900 I/Tizen::System( 1250): (259) > Active app [com.samsun], current [org.exampl] 
09-08 12:35:59.262+0900 I/Tizen::Io( 1250): (729) > Entry not found
09-08 12:35:59.272+0900 I/Tizen::System( 1250): (157) > change brightness system value.
09-08 12:35:59.282+0900 I/TIZEN_N_SOUND_MANAGER(  900): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=8, ret=0x0
09-08 12:35:59.282+0900 E/TIZEN_N_SOUND_MANAGER(  900): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-08 12:35:59.282+0900 I/TIZEN_N_SOUND_MANAGER(  900): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=4, ret=0x0
09-08 12:35:59.282+0900 E/TIZEN_N_SOUND_MANAGER(  900): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-08 12:35:59.282+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
09-08 12:35:59.993+0900 D/AclService( 1394): PowerThread.cpp: processCpuLock(96) > CPU requested: PowerManagerService.WakeLocks
09-08 12:36:00.023+0900 D/AclService( 1394): PowerThread.cpp: processCpuLock(109) > CPU released: PowerManagerService.WakeLocks
09-08 12:36:00.443+0900 W/CRASH_MANAGER( 7820): worker.c: worker_job(1199) > 1107813626173147330575
