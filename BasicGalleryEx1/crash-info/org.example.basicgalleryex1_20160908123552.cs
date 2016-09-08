S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPD4
Build-Date: 2016.04.11 14:59:15

Crash Information
Process Name: basicgalleryex1
PID: 7528
Date: 2016-09-08 12:35:52+0900
Executable File Path: /opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 7528, uid 5000)

Register Information
r0   = 0xb8a9fa68, r1   = 0x00000000
r2   = 0xb27bbc08, r3   = 0x8001389d
r4   = 0xb8a83318, r5   = 0xb8a7f6f8
r6   = 0x8001389d, r7   = 0xbeb940d0
r8   = 0xb27b3931, r9   = 0xbeb940fc
r10  = 0xb8ab3338, fp   = 0xbeb94284
ip   = 0x8000cc67, sp   = 0xbeb940a8
lr   = 0xb8a9fa68, pc   = 0xb27b3950
cpsr = 0xa00d0030

Memory Information
MemTotal:   987012 KB
MemFree:    134568 KB
Buffers:     20648 KB
Cached:     223000 KB
VmPeak:     116320 KB
VmSize:     116316 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22120 KB
VmRSS:       22120 KB
VmData:      33796 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35620 KB
VmPTE:          88 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 7528 TID = 7528
7528 7529 7807 7812 

Maps Information
b143f000 b1c3e000 rw-p [stack:7812]
b1c81000 b1c89000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1c9a000 b1c9b000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1cab000 b1cbf000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1cd3000 b1cd4000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1ce4000 b1ce7000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1cf8000 b1cf9000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1d09000 b1d0b000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1d1b000 b1d1d000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1d2d000 b1d3d000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1d4d000 b1d59000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1d6b000 b256a000 rw-p [stack:7807]
b276a000 b2771000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2782000 b278a000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b279c000 b27a2000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27b2000 b27b4000 r-xp /opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1
b2904000 b29e7000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a1e000 b2a46000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a58000 b3257000 rw-p [stack:7529]
b3257000 b3259000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3269000 b3273000 r-xp /lib/libnss_files-2.20-2014.11.so
b3284000 b328d000 r-xp /lib/libnss_nis-2.20-2014.11.so
b329e000 b32af000 r-xp /lib/libnsl-2.20-2014.11.so
b32c2000 b32c8000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32d9000 b32da000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3302000 b3309000 r-xp /usr/lib/libminizip.so.1.0.0
b3319000 b331e000 r-xp /usr/lib/libstorage.so.0.1
b332e000 b338d000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33a3000 b33b7000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33c7000 b340b000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b341b000 b3423000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3433000 b3463000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3476000 b352f000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3543000 b3596000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35a7000 b35c2000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35d2000 b3693000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36a6000 b36b6000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36c6000 b36d3000 r-xp /usr/lib/libmdm-common.so.1.0.98
b36e4000 b36eb000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b36fb000 b373c000 r-xp /usr/lib/libmdm.so.1.2.12
b374c000 b3754000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3763000 b3773000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3794000 b37f4000 r-xp /usr/lib/libasound.so.2.0.0
b3806000 b3809000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3819000 b381c000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b382c000 b3831000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3841000 b3842000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3852000 b385d000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3871000 b3878000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3888000 b388e000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b389e000 b38a3000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38b3000 b38ce000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38de000 b38e5000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b38f5000 b38f8000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3909000 b3937000 r-xp /usr/lib/libidn.so.11.5.44
b3947000 b395d000 r-xp /usr/lib/libnghttp2.so.5.4.0
b396e000 b3978000 r-xp /usr/lib/libcares.so.2.1.0
b3988000 b3992000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39a2000 b39a4000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39b4000 b39b5000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39c5000 b39c9000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39da000 b3a02000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a13000 b3a3c000 r-xp /usr/lib/libturbojpeg.so
b3a5c000 b3a62000 r-xp /usr/lib/libgif.so.4.1.6
b3a72000 b3ab8000 r-xp /usr/lib/libcurl.so.4.3.0
b3ac9000 b3aea000 r-xp /usr/lib/libexif.so.12.3.3
b3b05000 b3b1a000 r-xp /usr/lib/libtts.so
b3b2b000 b3b33000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b43000 b3c09000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c29000 b3d21000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d40000 b3e0e000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e25000 b3e27000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e37000 b3e3d000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e4d000 b3e70000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e81000 b3e83000 r-xp /usr/lib/libappsvc.so.0.1.0
b3e93000 b3e95000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3ea6000 b3eab000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3ec2000 b3ec4000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3ed4000 b3edb000 r-xp /usr/lib/libsensord-share.so
b3eeb000 b3f03000 r-xp /usr/lib/libsensor.so.1.1.0
b3f14000 b3f17000 r-xp /usr/lib/libXv.so.1.0.0
b3f27000 b3f2c000 r-xp /usr/lib/libutilX.so.1.1.0
b3f3c000 b3f41000 r-xp /usr/lib/libappcore-common.so.1.1
b3f51000 b3f58000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f6b000 b3f6f000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f80000 b405e000 r-xp /usr/lib/libCOREGL.so.4.0
b407e000 b4081000 r-xp /usr/lib/libuuid.so.1.3.0
b4091000 b40a8000 r-xp /usr/lib/libblkid.so.1.1.0
b40b9000 b40bb000 r-xp /usr/lib/libXau.so.6.0.0
b40cb000 b4112000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4124000 b412a000 r-xp /usr/lib/libjson-c.so.2.0.1
b413b000 b413f000 r-xp /usr/lib/libogg.so.0.7.1
b414f000 b4171000 r-xp /usr/lib/libvorbis.so.0.4.3
b4181000 b4265000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4281000 b4284000 r-xp /usr/lib/libEGL.so.1.4
b4295000 b429b000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42ab000 b42ad000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42bd000 b42ca000 r-xp /usr/lib/libGLESv2.so.2.0
b42db000 b433d000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4352000 b436a000 r-xp /usr/lib/libmount.so.1.1.0
b437c000 b4390000 r-xp /usr/lib/libxcb.so.1.1.0
b43a0000 b43a7000 r-xp /lib/libcrypt-2.20-2014.11.so
b43df000 b43e1000 r-xp /usr/lib/libiri.so
b43f1000 b43fc000 r-xp /usr/lib/libgpg-error.so.0.15.0
b440d000 b4443000 r-xp /usr/lib/libpulse.so.0.16.2
b4454000 b4497000 r-xp /usr/lib/libsndfile.so.1.0.25
b44ac000 b44c1000 r-xp /lib/libexpat.so.1.5.2
b44d3000 b4591000 r-xp /usr/lib/libcairo.so.2.11200.14
b45a5000 b45ad000 r-xp /usr/lib/libdrm.so.2.4.0
b45bd000 b45c0000 r-xp /usr/lib/libdri2.so.0.0.0
b45d0000 b461e000 r-xp /usr/lib/libssl.so.1.0.0
b4633000 b463f000 r-xp /usr/lib/libeeze.so.1.13.0
b4650000 b4659000 r-xp /usr/lib/libethumb.so.1.13.0
b4669000 b466c000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b467c000 b4833000 r-xp /usr/lib/libcrypto.so.1.0.0
b561e000 b5627000 r-xp /usr/lib/libXi.so.6.1.0
b5637000 b5639000 r-xp /usr/lib/libXgesture.so.7.0.0
b5649000 b564d000 r-xp /usr/lib/libXtst.so.6.1.0
b565d000 b5663000 r-xp /usr/lib/libXrender.so.1.3.0
b5673000 b5679000 r-xp /usr/lib/libXrandr.so.2.2.0
b5689000 b568b000 r-xp /usr/lib/libXinerama.so.1.0.0
b569c000 b569f000 r-xp /usr/lib/libXfixes.so.3.1.0
b56af000 b56ba000 r-xp /usr/lib/libXext.so.6.4.0
b56ca000 b56cc000 r-xp /usr/lib/libXdamage.so.1.1.0
b56dc000 b56de000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56ee000 b57d0000 r-xp /usr/lib/libX11.so.6.3.0
b57e4000 b57eb000 r-xp /usr/lib/libXcursor.so.1.0.2
b57fb000 b5813000 r-xp /usr/lib/libudev.so.1.6.0
b5815000 b5818000 r-xp /lib/libattr.so.1.1.0
b5828000 b5848000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5849000 b584e000 r-xp /usr/lib/libffi.so.6.0.2
b585f000 b5877000 r-xp /lib/libz.so.1.2.8
b5887000 b5889000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5899000 b596e000 r-xp /usr/lib/libxml2.so.2.9.2
b5983000 b5a1e000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a3a000 b5a3d000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a4d000 b5a66000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a77000 b5a88000 r-xp /lib/libresolv-2.20-2014.11.so
b5a9c000 b5b16000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b2b000 b5b2d000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b3d000 b5b44000 r-xp /usr/lib/libembryo.so.1.13.0
b5b54000 b5b5e000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b6f000 b5b87000 r-xp /usr/lib/libpng12.so.0.50.0
b5b98000 b5bbb000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bdc000 b5bf0000 r-xp /usr/lib/libector.so.1.13.0
b5c01000 b5c19000 r-xp /usr/lib/liblua-5.1.so
b5c2a000 b5c81000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c95000 b5cbd000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cce000 b5ce1000 r-xp /usr/lib/libfribidi.so.0.3.1
b5cf2000 b5d2c000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d3d000 b5d4b000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d5b000 b5d63000 r-xp /usr/lib/libtbm.so.1.0.0
b5d73000 b5d80000 r-xp /usr/lib/libeio.so.1.13.0
b5d90000 b5d92000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5da2000 b5da7000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5db7000 b5dce000 r-xp /usr/lib/libefreet.so.1.13.0
b5de0000 b5e00000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e10000 b5e30000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e32000 b5e38000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e48000 b5e59000 r-xp /usr/lib/libemotion.so.1.13.0
b5e6a000 b5e71000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e81000 b5e90000 r-xp /usr/lib/libeo.so.1.13.0
b5ea1000 b5eb3000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ec4000 b5ec9000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ed9000 b5ef2000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f02000 b5f1f000 r-xp /usr/lib/libeet.so.1.13.0
b5f38000 b5f80000 r-xp /usr/lib/libeina.so.1.13.0
b5f91000 b5fa1000 r-xp /usr/lib/libefl.so.1.13.0
b5fb2000 b6097000 r-xp /usr/lib/libicuuc.so.51.1
b60b4000 b61f4000 r-xp /usr/lib/libicui18n.so.51.1
b620b000 b6243000 r-xp /usr/lib/libecore_x.so.1.13.0
b6255000 b6258000 r-xp /lib/libcap.so.2.21
b6268000 b6291000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62a2000 b62a9000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62bb000 b62f2000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6303000 b63ee000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6401000 b647a000 r-xp /usr/lib/libsqlite3.so.0.8.6
b648c000 b6491000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64a1000 b64ab000 r-xp /usr/lib/libvconf.so.0.2.45
b64bb000 b64bd000 r-xp /usr/lib/libvasum.so.0.3.1
b64cd000 b64cf000 r-xp /usr/lib/libttrace.so.1.1
b64df000 b64e2000 r-xp /usr/lib/libiniparser.so.0
b64f2000 b6518000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6528000 b652d000 r-xp /usr/lib/libxdgmime.so.1.1.0
b653e000 b6555000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6566000 b65d1000 r-xp /lib/libm-2.20-2014.11.so
b65e2000 b65e8000 r-xp /lib/librt-2.20-2014.11.so
b65f9000 b6606000 r-xp /usr/lib/libunwind.so.8.0.1
b663c000 b6760000 r-xp /lib/libc-2.20-2014.11.so
b6775000 b678e000 r-xp /lib/libgcc_s-4.9.so.1
b679e000 b6880000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6891000 b68bb000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68cc000 b6908000 r-xp /usr/lib/libsystemd.so.0.4.0
b690a000 b698d000 r-xp /usr/lib/libedje.so.1.13.0
b69a0000 b69be000 r-xp /usr/lib/libecore.so.1.13.0
b69de000 b6b65000 r-xp /usr/lib/libevas.so.1.13.0
b6b9a000 b6bae000 r-xp /lib/libpthread-2.20-2014.11.so
b6bc2000 b6df6000 r-xp /usr/lib/libelementary.so.1.13.0
b6e25000 b6e29000 r-xp /usr/lib/libsmack.so.1.0.0
b6e39000 b6e40000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e50000 b6e52000 r-xp /usr/lib/libdlog.so.0.0.0
b6e62000 b6e65000 r-xp /usr/lib/libbundle.so.0.1.22
b6e75000 b6e77000 r-xp /lib/libdl-2.20-2014.11.so
b6e88000 b6ea0000 r-xp /usr/lib/libaul.so.0.1.0
b6eb4000 b6eb9000 r-xp /usr/lib/libappcore-efl.so.1.1
b6eca000 b6ed7000 r-xp /usr/lib/liblptcp.so
b6ee9000 b6eed000 r-xp /usr/lib/libsys-assert.so
b6efe000 b6f1e000 r-xp /lib/ld-2.20-2014.11.so
b6f2f000 b6f34000 r-xp /usr/bin/launchpad-loader
b8855000 b8b07000 rw-p [heap]
beb74000 beb95000 rw-p [stack]
b8855000 b8b07000 rw-p [heap]
beb74000 beb95000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7528)
Call Stack Count: 21
 0: gengrid_it_cb + 0x1f (0xb27b3950) [/opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1] + 0x1950
 1: (0xb6cb00d5) [/usr/lib/libelementary.so.1] + 0xee0d5
 2: (0xb6cb2533) [/usr/lib/libelementary.so.1] + 0xf0533
 3: (0xb6a13175) [/usr/lib/libevas.so.1] + 0x35175
 4: (0xb5e8c219) [/usr/lib/libeo.so.1] + 0xb219
 5: eo_event_callback_call + 0x68 (0xb5e8afb9) [/usr/lib/libeo.so.1] + 0x9fb9
 6: (0xb6a13515) [/usr/lib/libevas.so.1] + 0x35515
 7: (0xb6a135bf) [/usr/lib/libevas.so.1] + 0x355bf
 8: (0xb6a1bde7) [/usr/lib/libevas.so.1] + 0x3dde7
 9: evas_canvas_event_feed_mouse_up + 0x6a (0xb6a20ea7) [/usr/lib/libevas.so.1] + 0x42ea7
10: evas_event_feed_mouse_up + 0x30 (0xb6a248e9) [/usr/lib/libevas.so.1] + 0x468e9
11: (0xb466b1cb) [/usr/lib/libecore_input_evas.so.1] + 0x21cb
12: (0xb69abc4b) [/usr/lib/libecore.so.1] + 0xbc4b
13: (0xb69b1a5d) [/usr/lib/libecore.so.1] + 0x11a5d
14: ecore_main_loop_begin + 0x3e (0xb69b1c83) [/usr/lib/libecore.so.1] + 0x11c83
15: appcore_efl_main + 0x20c (0xb6eb72bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
16: ui_app_main + 0xc0 (0xb3f6d909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
17: main + 0x122 (0xb27b3373) [/opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1] + 0x1373
18: (0xb6f30bb5) [/opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1] + 0x1bb5
19: __libc_start_main + 0x114 (0xb66524bc) [/lib/libc.so.6] + 0x164bc
20: (0xb6f30eb4) [/opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1] + 0x1eb4
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
ndBundleViaMessagePort(653) > [0;40;31mCityName : 대전광역시[0;m
09-08 12:35:18.122+0900 E/weather-common( 7552): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : Daejeon[0;m
09-08 12:35:18.122+0900 E/weather-common( 7552): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : 28.900000[0;m
09-08 12:35:18.122+0900 E/weather-common( 7552): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : 30.500000[0;m
09-08 12:35:18.122+0900 E/weather-common( 7552): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : 70.300000[0;m
09-08 12:35:18.122+0900 E/weather-common( 7552): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : 2[0;m
09-08 12:35:18.122+0900 E/weather-common( 7552): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : 1472959134[0;m
09-08 12:35:18.122+0900 E/weather-common( 7552): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
09-08 12:35:18.122+0900 E/weather-common( 7552): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
09-08 12:35:18.122+0900 E/weather-agent( 7552): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
09-08 12:35:18.122+0900 E/weather-agent( 7552): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
09-08 12:35:18.122+0900 I/MESSAGE_PORT( 7552): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-08 12:35:18.222+0900 I/AclService( 1394): AppManagerService.cpp: onScreenStateChange(1710) > Screen state change received by (ACL111OMWW)
09-08 12:35:18.222+0900 I/Tizen::System( 1250): (280) > The screen has been turned on.
09-08 12:35:18.222+0900 I/Tizen::Io( 1250): (729) > Entry not found
09-08 12:35:18.242+0900 D/RILJ    ( 1690): [3664]> SCREEN_STATE: true
09-08 12:35:18.242+0900 D/RilRequest( 1690): [3664]< SCREEN_STATE error: com.android.internal.telephony.CommandException: RADIO_NOT_AVAILABLE ret=
09-08 12:35:18.252+0900 D/DCT     ( 1690): onReceive: action=android.intent.action.SCREEN_ON
09-08 12:35:18.252+0900 D/DCT     ( 1690): stopNetStatPoll
09-08 12:35:18.252+0900 D/DCT     ( 1690): overall state is IDLE
09-08 12:35:18.252+0900 I/Tizen::System( 1250): (157) > change brightness system value.
09-08 12:35:18.262+0900 E/INDICATOR(  659): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-08 12:35:18.272+0900 E/INDICATOR(  659): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-08 12:35:18.272+0900 E/INDICATOR(  659): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-08 12:35:18.272+0900 E/INDICATOR(  659): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-08 12:35:18.272+0900 E/INDICATOR(  659): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-08 12:35:18.272+0900 E/INDICATOR(  659): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-08 12:35:18.272+0900 E/INDICATOR(  659): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
09-08 12:35:18.272+0900 E/INDICATOR(  659): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-08 12:35:18.272+0900 E/INDICATOR(  659): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-08 12:35:18.272+0900 E/INDICATOR(  659): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-08 12:35:18.272+0900 E/INDICATOR(  659): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-08 12:35:18.272+0900 E/INDICATOR(  659): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-08 12:35:18.302+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
09-08 12:35:18.312+0900 E/EFL     (  842): ecore_x<842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=4196646
09-08 12:35:18.322+0900 W/LOCKSCREEN(  842): dbus.c: _dbus_message_recv_cb(154) > [_dbus_message_recv_cb:154:W] POST_LCD_ON status 2 visibility(1)
09-08 12:35:18.372+0900 E/EFL     (  842): ecore_x<842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=4196779
09-08 12:35:18.382+0900 E/LOCKSCREEN(  842): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
09-08 12:35:18.382+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80001:VIEW_GESTURED
09-08 12:35:18.382+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:80001 event_info:0
09-08 12:35:18.382+0900 W/LOCKSCREEN(  842): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
09-08 12:35:18.382+0900 W/LOCKSCREEN(  842): view-mgr.c: _event_route(130) > [_event_route:130:W] event:80001 event_info:0
09-08 12:35:18.382+0900 W/LOCKSCREEN(  842): view-mgr.c: _state_transit(46) > [_state_transit:46:W] state transit:2
09-08 12:35:18.382+0900 W/LOCKSCREEN(  842): view-mgr.c: _state_transit(49) > [_state_transit:49:W] already in same state:2
09-08 12:35:18.382+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:4:LKD_EVT_WILL_UNLOCK
09-08 12:35:18.382+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:4 event_info:0
09-08 12:35:18.382+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event_delay(1041) > [lockd_event_delay:1041:W] dealyed event:2:UNLOCK wait for:0.330000
09-08 12:35:18.382+0900 E/LOCKSCREEN(  842): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
09-08 12:35:18.713+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:2 event_info:0
09-08 12:35:18.713+0900 W/LOCKSCREEN(  842): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:7
09-08 12:35:18.713+0900 W/LOCKSCREEN(  842): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => HIDE
09-08 12:35:18.713+0900 E/LOCKSCREEN(  842): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
09-08 12:35:18.713+0900 E/LOCKSCREEN(  842): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
09-08 12:35:18.713+0900 E/LOCKSCREEN(  842): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-08 12:35:18.713+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
09-08 12:35:18.713+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
09-08 12:35:18.713+0900 W/LOCKSCREEN(  842): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
09-08 12:35:18.723+0900 E/EFL     (  330): eo<330> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-08 12:35:18.723+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
09-08 12:35:18.723+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-08 12:35:18.723+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
09-08 12:35:18.733+0900 E/EFL     (  330): eo<330> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-08 12:35:18.733+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(842) status(4)
09-08 12:35:18.733+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.lockscreen(842)
09-08 12:35:18.733+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 842, appid: com.samsung.lockscreen, status: bg
09-08 12:35:18.733+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
09-08 12:35:18.733+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-08 12:35:18.733+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
09-08 12:35:18.733+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
09-08 12:35:18.733+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
09-08 12:35:18.753+0900 I/Tizen::System( 1250): (259) > Active app [com.samsun], current [com.samsun] 
09-08 12:35:18.753+0900 I/Tizen::System( 1250): (273) > Current App[com.samsun] is already actived.
09-08 12:35:18.783+0900 W/LOCKSCREEN(  842): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2E00007] is [invisible]
09-08 12:35:18.783+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10002:WIN_BECOME_INVISIBLE
09-08 12:35:18.783+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:10002 event_info:0
09-08 12:35:18.793+0900 E/LOCKSCREEN(  842): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
09-08 12:35:18.793+0900 I/APP_CORE(  842): appcore-efl.c: __do_app(514) > [APP 842] Event: PAUSE State: RUNNING
09-08 12:35:18.793+0900 I/CAPI_APPFW_APPLICATION(  842): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-08 12:35:18.793+0900 E/LOCKSCREEN(  842): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-08 12:35:18.793+0900 E/LOCKSCREEN(  842): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
09-08 12:35:18.793+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20002:APP_PAUSE
09-08 12:35:18.793+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:20002 event_info:0
09-08 12:35:18.793+0900 W/LOCKSCREEN(  842): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
09-08 12:35:18.803+0900 E/LOCKSCREEN(  842): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
09-08 12:35:18.813+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
09-08 12:35:18.823+0900 I/APP_CORE(  842): appcore-efl.c: __do_app(514) > [APP 842] Event: MEM_FLUSH State: PAUSED
09-08 12:35:18.893+0900 W/LOCKSCREEN(  842): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
09-08 12:35:18.893+0900 E/LOCKSCREEN(  842): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
09-08 12:35:18.893+0900 E/LOCKSCREEN(  842): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-08 12:35:18.893+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
09-08 12:35:18.893+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
09-08 12:35:19.123+0900 E/weather-agent( 7552): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
09-08 12:35:19.123+0900 I/CAPI_APPFW_APPLICATION( 7552): service_app_main.c: service_app_exit(446) > service_app_exit
09-08 12:35:19.123+0900 E/weather-agent( 7552): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
09-08 12:35:19.123+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
09-08 12:35:19.123+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
09-08 12:35:19.263+0900 W/AUL_AMD (  610): amd_request.c: __send_app_termination_signal(609) > send dead signal done
09-08 12:35:19.263+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 7552
09-08 12:35:19.263+0900 I/Tizen::App( 1250): (243) > App[com.samsung.weather-m-agent] pid[7552] terminate event is forwarded
09-08 12:35:19.263+0900 I/Tizen::System( 1250): (256) > osp.accessorymanager.service provider is found.
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
09-08 12:35:52.766+0900 W/CRASH_MANAGER( 7820): worker.c: worker_job(1199) > 1107528626173147330575
