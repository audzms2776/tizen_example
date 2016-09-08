S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPD4
Build-Date: 2016.04.11 14:59:15

Crash Information
Process Name: basicgalleryex1
PID: 5832
Date: 2016-09-08 12:24:52+0900
Executable File Path: /opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 5832, uid 5000)

Register Information
r0   = 0x80008c47, r1   = 0xbed523c4
r2   = 0x80008c47, r3   = 0xb3eb5000
r4   = 0xb3f76a3c, r5   = 0xbed534d4
r6   = 0x00000001, r7   = 0xbed533e0
r8   = 0xbed534c8, r9   = 0xb866c698
r10  = 0xbed534e8, fp   = 0x00000000
ip   = 0xb5f87120, sp   = 0xbed52380
lr   = 0xb27aa59d, pc   = 0xb27aa6b2
cpsr = 0x80000030

Memory Information
MemTotal:   987012 KB
MemFree:     82364 KB
Buffers:     25468 KB
Cached:     260492 KB
VmPeak:      89176 KB
VmSize:      89172 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19016 KB
VmRSS:       19016 KB
VmData:      22000 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35620 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 5832 TID = 5832
5832 5836 5844 

Maps Information
b1c78000 b1c80000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1c91000 b1c92000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1ca2000 b1cb6000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1cca000 b1ccb000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1cdb000 b1cde000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1cef000 b1cf0000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1d00000 b1d02000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1d12000 b1d14000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1d24000 b1d34000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1d44000 b1d50000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1d62000 b2561000 rw-p [stack:5844]
b2761000 b2768000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2779000 b2781000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b2793000 b2799000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27a9000 b27ab000 r-xp /opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1
b28fb000 b29de000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a15000 b2a3d000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a4f000 b324e000 rw-p [stack:5836]
b324e000 b3250000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3260000 b326a000 r-xp /lib/libnss_files-2.20-2014.11.so
b327b000 b3284000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3295000 b32a6000 r-xp /lib/libnsl-2.20-2014.11.so
b32b9000 b32bf000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32d0000 b32d1000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b32f9000 b3300000 r-xp /usr/lib/libminizip.so.1.0.0
b3310000 b3315000 r-xp /usr/lib/libstorage.so.0.1
b3325000 b3384000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b339a000 b33ae000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33be000 b3402000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3412000 b341a000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b342a000 b345a000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b346d000 b3526000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b353a000 b358d000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b359e000 b35b9000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35c9000 b368a000 r-xp /usr/lib/libprotobuf.so.9.0.1
b369d000 b36ad000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36bd000 b36ca000 r-xp /usr/lib/libmdm-common.so.1.0.98
b36db000 b36e2000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b36f2000 b3733000 r-xp /usr/lib/libmdm.so.1.2.12
b3743000 b374b000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b375a000 b376a000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b378b000 b37eb000 r-xp /usr/lib/libasound.so.2.0.0
b37fd000 b3800000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3810000 b3813000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3823000 b3828000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3838000 b3839000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3849000 b3854000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3868000 b386f000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b387f000 b3885000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3895000 b389a000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38aa000 b38c5000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38d5000 b38dc000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b38ec000 b38ef000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3900000 b392e000 r-xp /usr/lib/libidn.so.11.5.44
b393e000 b3954000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3965000 b396f000 r-xp /usr/lib/libcares.so.2.1.0
b397f000 b3989000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3999000 b399b000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39ab000 b39ac000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39bc000 b39c0000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39d1000 b39f9000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a0a000 b3a33000 r-xp /usr/lib/libturbojpeg.so
b3a53000 b3a59000 r-xp /usr/lib/libgif.so.4.1.6
b3a69000 b3aaf000 r-xp /usr/lib/libcurl.so.4.3.0
b3ac0000 b3ae1000 r-xp /usr/lib/libexif.so.12.3.3
b3afc000 b3b11000 r-xp /usr/lib/libtts.so
b3b22000 b3b2a000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b3a000 b3c00000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c20000 b3d18000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d37000 b3e05000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e1c000 b3e1e000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e2e000 b3e34000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e44000 b3e67000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e78000 b3e7a000 r-xp /usr/lib/libappsvc.so.0.1.0
b3e8a000 b3e8c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3e9d000 b3ea2000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3eb9000 b3ebb000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3ecb000 b3ed2000 r-xp /usr/lib/libsensord-share.so
b3ee2000 b3efa000 r-xp /usr/lib/libsensor.so.1.1.0
b3f0b000 b3f0e000 r-xp /usr/lib/libXv.so.1.0.0
b3f1e000 b3f23000 r-xp /usr/lib/libutilX.so.1.1.0
b3f33000 b3f38000 r-xp /usr/lib/libappcore-common.so.1.1
b3f48000 b3f4f000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f62000 b3f66000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f77000 b4055000 r-xp /usr/lib/libCOREGL.so.4.0
b4075000 b4078000 r-xp /usr/lib/libuuid.so.1.3.0
b4088000 b409f000 r-xp /usr/lib/libblkid.so.1.1.0
b40b0000 b40b2000 r-xp /usr/lib/libXau.so.6.0.0
b40c2000 b4109000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b411b000 b4121000 r-xp /usr/lib/libjson-c.so.2.0.1
b4132000 b4136000 r-xp /usr/lib/libogg.so.0.7.1
b4146000 b4168000 r-xp /usr/lib/libvorbis.so.0.4.3
b4178000 b425c000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4278000 b427b000 r-xp /usr/lib/libEGL.so.1.4
b428c000 b4292000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42a2000 b42a4000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42b4000 b42c1000 r-xp /usr/lib/libGLESv2.so.2.0
b42d2000 b4334000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4349000 b4361000 r-xp /usr/lib/libmount.so.1.1.0
b4373000 b4387000 r-xp /usr/lib/libxcb.so.1.1.0
b4397000 b439e000 r-xp /lib/libcrypt-2.20-2014.11.so
b43d6000 b43d8000 r-xp /usr/lib/libiri.so
b43e8000 b43f3000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4404000 b443a000 r-xp /usr/lib/libpulse.so.0.16.2
b444b000 b448e000 r-xp /usr/lib/libsndfile.so.1.0.25
b44a3000 b44b8000 r-xp /lib/libexpat.so.1.5.2
b44ca000 b4588000 r-xp /usr/lib/libcairo.so.2.11200.14
b459c000 b45a4000 r-xp /usr/lib/libdrm.so.2.4.0
b45b4000 b45b7000 r-xp /usr/lib/libdri2.so.0.0.0
b45c7000 b4615000 r-xp /usr/lib/libssl.so.1.0.0
b462a000 b4636000 r-xp /usr/lib/libeeze.so.1.13.0
b4647000 b4650000 r-xp /usr/lib/libethumb.so.1.13.0
b4660000 b4663000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4673000 b482a000 r-xp /usr/lib/libcrypto.so.1.0.0
b5615000 b561e000 r-xp /usr/lib/libXi.so.6.1.0
b562e000 b5630000 r-xp /usr/lib/libXgesture.so.7.0.0
b5640000 b5644000 r-xp /usr/lib/libXtst.so.6.1.0
b5654000 b565a000 r-xp /usr/lib/libXrender.so.1.3.0
b566a000 b5670000 r-xp /usr/lib/libXrandr.so.2.2.0
b5680000 b5682000 r-xp /usr/lib/libXinerama.so.1.0.0
b5693000 b5696000 r-xp /usr/lib/libXfixes.so.3.1.0
b56a6000 b56b1000 r-xp /usr/lib/libXext.so.6.4.0
b56c1000 b56c3000 r-xp /usr/lib/libXdamage.so.1.1.0
b56d3000 b56d5000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56e5000 b57c7000 r-xp /usr/lib/libX11.so.6.3.0
b57db000 b57e2000 r-xp /usr/lib/libXcursor.so.1.0.2
b57f2000 b580a000 r-xp /usr/lib/libudev.so.1.6.0
b580c000 b580f000 r-xp /lib/libattr.so.1.1.0
b581f000 b583f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5840000 b5845000 r-xp /usr/lib/libffi.so.6.0.2
b5856000 b586e000 r-xp /lib/libz.so.1.2.8
b587e000 b5880000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5890000 b5965000 r-xp /usr/lib/libxml2.so.2.9.2
b597a000 b5a15000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a31000 b5a34000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a44000 b5a5d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a6e000 b5a7f000 r-xp /lib/libresolv-2.20-2014.11.so
b5a93000 b5b0d000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b22000 b5b24000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b34000 b5b3b000 r-xp /usr/lib/libembryo.so.1.13.0
b5b4b000 b5b55000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b66000 b5b7e000 r-xp /usr/lib/libpng12.so.0.50.0
b5b8f000 b5bb2000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bd3000 b5be7000 r-xp /usr/lib/libector.so.1.13.0
b5bf8000 b5c10000 r-xp /usr/lib/liblua-5.1.so
b5c21000 b5c78000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c8c000 b5cb4000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cc5000 b5cd8000 r-xp /usr/lib/libfribidi.so.0.3.1
b5ce9000 b5d23000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d34000 b5d42000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d52000 b5d5a000 r-xp /usr/lib/libtbm.so.1.0.0
b5d6a000 b5d77000 r-xp /usr/lib/libeio.so.1.13.0
b5d87000 b5d89000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d99000 b5d9e000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5dae000 b5dc5000 r-xp /usr/lib/libefreet.so.1.13.0
b5dd7000 b5df7000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e07000 b5e27000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e29000 b5e2f000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e3f000 b5e50000 r-xp /usr/lib/libemotion.so.1.13.0
b5e61000 b5e68000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e78000 b5e87000 r-xp /usr/lib/libeo.so.1.13.0
b5e98000 b5eaa000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ebb000 b5ec0000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ed0000 b5ee9000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5ef9000 b5f16000 r-xp /usr/lib/libeet.so.1.13.0
b5f2f000 b5f77000 r-xp /usr/lib/libeina.so.1.13.0
b5f88000 b5f98000 r-xp /usr/lib/libefl.so.1.13.0
b5fa9000 b608e000 r-xp /usr/lib/libicuuc.so.51.1
b60ab000 b61eb000 r-xp /usr/lib/libicui18n.so.51.1
b6202000 b623a000 r-xp /usr/lib/libecore_x.so.1.13.0
b624c000 b624f000 r-xp /lib/libcap.so.2.21
b625f000 b6288000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6299000 b62a0000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62b2000 b62e9000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62fa000 b63e5000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63f8000 b6471000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6483000 b6488000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6498000 b64a2000 r-xp /usr/lib/libvconf.so.0.2.45
b64b2000 b64b4000 r-xp /usr/lib/libvasum.so.0.3.1
b64c4000 b64c6000 r-xp /usr/lib/libttrace.so.1.1
b64d6000 b64d9000 r-xp /usr/lib/libiniparser.so.0
b64e9000 b650f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b651f000 b6524000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6535000 b654c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b655d000 b65c8000 r-xp /lib/libm-2.20-2014.11.so
b65d9000 b65df000 r-xp /lib/librt-2.20-2014.11.so
b65f0000 b65fd000 r-xp /usr/lib/libunwind.so.8.0.1
b6633000 b6757000 r-xp /lib/libc-2.20-2014.11.so
b676c000 b6785000 r-xp /lib/libgcc_s-4.9.so.1
b6795000 b6877000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6888000 b68b2000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68c3000 b68ff000 r-xp /usr/lib/libsystemd.so.0.4.0
b6901000 b6984000 r-xp /usr/lib/libedje.so.1.13.0
b6997000 b69b5000 r-xp /usr/lib/libecore.so.1.13.0
b69d5000 b6b5c000 r-xp /usr/lib/libevas.so.1.13.0
b6b91000 b6ba5000 r-xp /lib/libpthread-2.20-2014.11.so
b6bb9000 b6ded000 r-xp /usr/lib/libelementary.so.1.13.0
b6e1c000 b6e20000 r-xp /usr/lib/libsmack.so.1.0.0
b6e30000 b6e37000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e47000 b6e49000 r-xp /usr/lib/libdlog.so.0.0.0
b6e59000 b6e5c000 r-xp /usr/lib/libbundle.so.0.1.22
b6e6c000 b6e6e000 r-xp /lib/libdl-2.20-2014.11.so
b6e7f000 b6e97000 r-xp /usr/lib/libaul.so.0.1.0
b6eab000 b6eb0000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ec1000 b6ece000 r-xp /usr/lib/liblptcp.so
b6ee0000 b6ee4000 r-xp /usr/lib/libsys-assert.so
b6ef5000 b6f15000 r-xp /lib/ld-2.20-2014.11.so
b6f26000 b6f2b000 r-xp /usr/bin/launchpad-loader
b8602000 b8842000 rw-p [heap]
bed33000 bed54000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5832)
Call Stack Count: 10
 0: create_gengrid + 0x11 (0xb27aa6b2) [/opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1] + 0x16b2
 1: create_base_gui + 0x130 (0xb27aa59d) [/opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1] + 0x159d
 2: app_create + 0x12 (0xb27aa3ab) [/opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1] + 0x13ab
 3: (0xb3f644f9) [/usr/lib/libcapi-appfw-application.so.0] + 0x24f9
 4: appcore_efl_main + 0x152 (0xb6eae203) [/usr/lib/libappcore-efl.so.1] + 0x3203
 5: ui_app_main + 0xc0 (0xb3f64909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
 6: main + 0x122 (0xb27aa333) [/opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1] + 0x1333
 7: (0xb6f27bb5) [/opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1] + 0x1bb5
 8: __libc_start_main + 0x114 (0xb66494bc) [/lib/libc.so.6] + 0x164bc
 9: (0xb6f27eb4) [/opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1] + 0x1eb4
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
enu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.basicgalleryex1]
09-08 12:24:12.192+0900 I/Tizen::App( 1250): (416) > appName = [basicgalleryex1]
09-08 12:24:12.192+0900 I/Tizen::App( 1250): (509) > exe = [/opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1], displayName = [basicgalleryex1], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
09-08 12:24:12.203+0900 E/PKGMGR_INFO( 1250): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
09-08 12:24:12.203+0900 I/Tizen::App( 1250): (683) > Application count(1) in this package
09-08 12:24:12.203+0900 I/Tizen::App( 1250): (840) > Enter.
09-08 12:24:12.203+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[basicgalleryex1] enable[1] system[0]
09-08 12:24:12.213+0900 E/HOME_APPS(  860): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.basicgalleryex1] mdm is not enabled
09-08 12:24:12.213+0900 I/Tizen::App( 1250): (703) > Exit.
09-08 12:24:12.213+0900 I/Tizen::App( 1250): (1584) > Package = [org.example.basicgalleryex1], Key = [end], Value = [ok], install = [1]
09-08 12:24:12.213+0900 E/cluster-home(  860): mainmenu-data-manager.cpp: GetBoxDataByAppId(2539) >  cannot find box with appid[org.example.basicgalleryex1]
09-08 12:24:12.213+0900 I/Tizen::App( 1250): (416) > appName = [basicgalleryex1]
09-08 12:24:12.213+0900 I/Tizen::App( 1250): (509) > exe = [/opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1], displayName = [basicgalleryex1], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
09-08 12:24:12.213+0900 I/Tizen::App( 1250): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.basicgalleryex1.info]
09-08 12:24:12.213+0900 I/Tizen::App( 1250): (131) > Enter
09-08 12:24:12.223+0900 I/Tizen::App( 1250): (137) > org.example.basicgalleryex1 does not have launch condition
09-08 12:24:12.223+0900 I/Tizen::App( 1250): (883) > Exit.
09-08 12:24:12.223+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[basicgalleryex1] enable[1] system[0]
09-08 12:24:12.243+0900 E/util-view(  860): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
09-08 12:24:12.253+0900 E/util-view(  860): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
09-08 12:24:12.603+0900 E/PKGMGR_SERVER( 5687): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
09-08 12:24:12.603+0900 E/PKGMGR_SERVER( 5687): pkgmgr-server.c: main(2471) > package manager server terminated.
09-08 12:24:13.914+0900 E/INDICATOR(  659): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-08 12:24:13.914+0900 E/INDICATOR(  659): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-08 12:24:13.914+0900 E/INDICATOR(  659): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-08 12:24:13.914+0900 E/INDICATOR(  659): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-08 12:24:13.914+0900 E/INDICATOR(  659): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-08 12:24:13.914+0900 E/INDICATOR(  659): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-08 12:24:13.914+0900 E/INDICATOR(  659): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
09-08 12:24:13.914+0900 E/INDICATOR(  659): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-08 12:24:13.914+0900 E/INDICATOR(  659): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-08 12:24:13.914+0900 E/INDICATOR(  659): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-08 12:24:13.914+0900 E/INDICATOR(  659): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-08 12:24:13.914+0900 E/INDICATOR(  659): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-08 12:24:14.535+0900 E/AUL_AMD (  610): amd_launch.c: _amd_proc_find_proc_info(1914) > proc info not found
09-08 12:24:17.708+0900 W/AUL     ( 5746): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.basicgalleryex1)
09-08 12:24:17.708+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
09-08 12:24:17.718+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
09-08 12:24:17.718+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
09-08 12:24:17.718+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
09-08 12:24:17.718+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 5746
09-08 12:24:17.718+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
09-08 12:24:17.728+0900 E/RESOURCED(  671): block.c: block_prelaunch_state(134) > insert data org.example.basicgalleryex1, table num : 8
09-08 12:24:17.728+0900 E/RESOURCED(  671): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-08 12:24:17.728+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
09-08 12:24:17.738+0900 W/AUL_PAD ( 1491): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
09-08 12:24:17.738+0900 W/AUL_PAD ( 1491): launchpad.c: __send_result_to_caller(267) > Check app launching
09-08 12:24:17.748+0900 I/CAPI_APPFW_APPLICATION( 5533): app_main.c: ui_app_main(789) > app_efl_main
09-08 12:24:17.758+0900 I/CAPI_APPFW_APPLICATION( 5533): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
09-08 12:24:17.778+0900 E/TBM     ( 5533): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
09-08 12:24:17.838+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 5533, appid: org.example.basicgalleryex1
09-08 12:24:17.838+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
09-08 12:24:17.838+0900 E/RESOURCED(  671): proc-main.c: proc_add_program_list(237) > not found ppi : org.example.basicgalleryex1
09-08 12:24:17.848+0900 W/AUL     ( 5746): launch.c: app_request_to_launchpad(425) > request cmd(0) result(5533)
09-08 12:24:18.088+0900 W/CRASH_MANAGER( 5761): worker.c: worker_job(1199) > 11055336261731473305057
09-08 12:24:18.829+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-08 12:24:18.829+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
09-08 12:24:18.879+0900 I/AUL_PAD ( 1491): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 5533 pgid = 5533
09-08 12:24:18.879+0900 I/AUL_PAD ( 1491): sigchild.h: __sigchild_action(143) > dead_pid(5533)
09-08 12:24:18.879+0900 E/Tizen::App( 1250): (703) > Cannot acquire app for 5533.
09-08 12:24:18.889+0900 E/RESOURCED(  671): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.684
09-08 12:24:18.939+0900 I/AUL_PAD ( 1491): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-08 12:24:18.939+0900 I/AUL_PAD ( 1491): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-08 12:24:18.939+0900 E/AUL_PAD ( 1491): launchpad.c: main(698) > error reading sigchld info
09-08 12:24:18.939+0900 I/Tizen::App( 1250): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 5533.
09-08 12:24:18.939+0900 I/ESD     (  880): esd_main.c: __esd_app_dead_handler(1773) > pid: 5533
09-08 12:24:18.939+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 5533
09-08 12:24:18.939+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 5533
09-08 12:24:18.959+0900 E/RESOURCED(  671): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.685
09-08 12:24:19.740+0900 I/UXT     ( 5770): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
09-08 12:24:29.269+0900 E/INDICATOR(  659): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-08 12:24:29.269+0900 E/INDICATOR(  659): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-08 12:24:29.269+0900 E/INDICATOR(  659): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-08 12:24:29.269+0900 E/INDICATOR(  659): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-08 12:24:29.269+0900 E/INDICATOR(  659): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-08 12:24:29.269+0900 E/INDICATOR(  659): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-08 12:24:29.269+0900 E/INDICATOR(  659): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
09-08 12:24:29.269+0900 E/INDICATOR(  659): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-08 12:24:29.269+0900 E/INDICATOR(  659): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-08 12:24:29.269+0900 E/INDICATOR(  659): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-08 12:24:29.279+0900 E/INDICATOR(  659): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-08 12:24:29.279+0900 E/INDICATOR(  659): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-08 12:24:47.397+0900 E/EFL     ( 5497): ecore_x<5497> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=3565752
09-08 12:24:47.397+0900 E/EFL     ( 5497): ecore_x<5497> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=3565790
09-08 12:24:47.407+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
09-08 12:24:47.407+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-08 12:24:47.407+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
09-08 12:24:47.407+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
09-08 12:24:47.407+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
09-08 12:24:47.447+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 36
09-08 12:24:47.457+0900 E/EFL     (  330): eo<330> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-08 12:24:47.457+0900 E/EFL     (  330): eo<330> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-08 12:24:47.487+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
09-08 12:24:47.487+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-08 12:24:47.487+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
09-08 12:24:47.497+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
09-08 12:24:47.497+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(5497) status(4)
09-08 12:24:47.497+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.basicgenlustex1(5497)
09-08 12:24:47.497+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 5497, appid: org.example.basicgenlustex1, status: bg
09-08 12:24:47.507+0900 I/APP_CORE( 5497): appcore-efl.c: __do_app(514) > [APP 5497] Event: PAUSE State: RUNNING
09-08 12:24:47.507+0900 I/CAPI_APPFW_APPLICATION( 5497): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-08 12:24:47.517+0900 W/HOME_APPS(  860): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.basicgalleryex1/shared/res/basicgalleryex1.png], Loading state:[1]
09-08 12:24:47.547+0900 I/TIZEN_N_EFL_UTIL_WINDOW( 5497): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 40
09-08 12:24:47.547+0900 E/APP_CORE( 5497): appcore-efl.c: _capture_and_make_file(1619) > win[7800002] widget[720] height[1280]
09-08 12:24:47.557+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 33
09-08 12:24:47.557+0900 I/Tizen::System( 1250): (259) > Active app [com.samsun], current [org.exampl] 
09-08 12:24:47.557+0900 I/Tizen::Io( 1250): (729) > Entry not found
09-08 12:24:47.587+0900 I/TIZEN_N_SOUND_MANAGER(  900): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=8, ret=0x0
09-08 12:24:47.587+0900 E/TIZEN_N_SOUND_MANAGER(  900): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-08 12:24:47.587+0900 I/Tizen::System( 1250): (157) > change brightness system value.
09-08 12:24:47.587+0900 I/TIZEN_N_SOUND_MANAGER(  900): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=4, ret=0x0
09-08 12:24:47.587+0900 E/TIZEN_N_SOUND_MANAGER(  900): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-08 12:24:47.597+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
09-08 12:24:49.209+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=3567612
09-08 12:24:49.269+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=3567677
09-08 12:24:49.279+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.basicgalleryex1)
09-08 12:24:49.279+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
09-08 12:24:49.279+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 860
09-08 12:24:49.289+0900 E/RESOURCED(  671): block.c: block_prelaunch_state(134) > insert data org.example.basicgalleryex1, table num : 8
09-08 12:24:49.289+0900 E/RESOURCED(  671): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-08 12:24:49.289+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
09-08 12:24:49.289+0900 W/AUL_PAD ( 1491): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
09-08 12:24:49.289+0900 W/AUL_PAD ( 1491): launchpad.c: __send_result_to_caller(267) > Check app launching
09-08 12:24:49.309+0900 I/CAPI_APPFW_APPLICATION( 5770): app_main.c: ui_app_main(789) > app_efl_main
09-08 12:24:49.309+0900 I/CAPI_APPFW_APPLICATION( 5770): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
09-08 12:24:49.339+0900 E/TBM     ( 5770): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
09-08 12:24:49.389+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 5770, appid: org.example.basicgalleryex1
09-08 12:24:49.389+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
09-08 12:24:49.389+0900 E/RESOURCED(  671): proc-main.c: proc_add_program_list(237) > not found ppi : org.example.basicgalleryex1
09-08 12:24:49.409+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(425) > request cmd(1) result(5770)
09-08 12:24:49.519+0900 W/CRASH_MANAGER( 5761): worker.c: worker_job(1199) > 11057706261731473305089
09-08 12:24:50.410+0900 I/AUL_PAD ( 1491): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 5770 pgid = 5770
09-08 12:24:50.410+0900 I/AUL_PAD ( 1491): sigchild.h: __sigchild_action(143) > dead_pid(5770)
09-08 12:24:50.420+0900 E/Tizen::App( 1250): (703) > Cannot acquire app for 5770.
09-08 12:24:50.420+0900 E/RESOURCED(  671): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.688
09-08 12:24:50.450+0900 I/AUL_PAD ( 1491): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-08 12:24:50.450+0900 I/AUL_PAD ( 1491): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-08 12:24:50.450+0900 E/AUL_PAD ( 1491): launchpad.c: main(698) > error reading sigchld info
09-08 12:24:50.460+0900 I/Tizen::App( 1250): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 5770.
09-08 12:24:50.460+0900 I/ESD     (  880): esd_main.c: __esd_app_dead_handler(1773) > pid: 5770
09-08 12:24:50.460+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 5770
09-08 12:24:50.460+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 5770
09-08 12:24:50.460+0900 E/RESOURCED(  671): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.689
09-08 12:24:51.201+0900 I/UXT     ( 5832): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
09-08 12:24:51.441+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=3569842
09-08 12:24:51.871+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=3570273
09-08 12:24:52.131+0900 W/cluster-view(  860): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2308) >  booster timer is still running on apps-view, Stop boost timer!!!
09-08 12:24:52.222+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=3570626
09-08 12:24:52.302+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=3570703
09-08 12:24:52.302+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.basicgalleryex1)
09-08 12:24:52.302+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
09-08 12:24:52.302+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 860
09-08 12:24:52.322+0900 E/RESOURCED(  671): block.c: block_prelaunch_state(134) > insert data org.example.basicgalleryex1, table num : 8
09-08 12:24:52.322+0900 E/RESOURCED(  671): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-08 12:24:52.322+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
09-08 12:24:52.322+0900 W/AUL_PAD ( 1491): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
09-08 12:24:52.322+0900 W/AUL_PAD ( 1491): launchpad.c: __send_result_to_caller(267) > Check app launching
09-08 12:24:52.332+0900 I/CAPI_APPFW_APPLICATION( 5832): app_main.c: ui_app_main(789) > app_efl_main
09-08 12:24:52.342+0900 I/CAPI_APPFW_APPLICATION( 5832): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
09-08 12:24:52.362+0900 E/TBM     ( 5832): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
09-08 12:24:52.422+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 5832, appid: org.example.basicgalleryex1
09-08 12:24:52.422+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
09-08 12:24:52.422+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(425) > request cmd(1) result(5832)
09-08 12:24:52.422+0900 E/RESOURCED(  671): proc-main.c: proc_add_program_list(237) > not found ppi : org.example.basicgalleryex1
09-08 12:24:52.502+0900 I/APP_CORE( 5497): appcore-efl.c: __do_app(514) > [APP 5497] Event: MEM_FLUSH State: PAUSED
09-08 12:24:52.792+0900 E/EFL     (  610): ecore_x<610> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=3571193
09-08 12:24:52.872+0900 E/EFL     (  610): ecore_x<610> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=3571270
09-08 12:24:53.092+0900 E/EFL     (  610): ecore_x<610> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=3571491
09-08 12:24:53.192+0900 E/EFL     (  610): ecore_x<610> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=3571590
09-08 12:24:53.363+0900 E/EFL     (  610): ecore_x<610> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=3571768
09-08 12:24:53.443+0900 I/AUL_PAD ( 1491): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 5832 pgid = 5832
09-08 12:24:53.443+0900 I/AUL_PAD ( 1491): sigchild.h: __sigchild_action(143) > dead_pid(5832)
09-08 12:24:53.443+0900 E/Tizen::App( 1250): (703) > Cannot acquire app for 5832.
09-08 12:24:53.453+0900 E/RESOURCED(  671): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.692
09-08 12:24:53.473+0900 I/AUL_PAD ( 1491): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-08 12:24:53.473+0900 I/AUL_PAD ( 1491): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-08 12:24:53.473+0900 E/AUL_PAD ( 1491): launchpad.c: main(698) > error reading sigchld info
09-08 12:24:53.483+0900 I/Tizen::App( 1250): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 5832.
09-08 12:24:53.483+0900 I/ESD     (  880): esd_main.c: __esd_app_dead_handler(1773) > pid: 5832
09-08 12:24:53.483+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 5832
09-08 12:24:53.483+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 5832
09-08 12:24:53.483+0900 E/RESOURCED(  671): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.693
09-08 12:24:53.673+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=3572077
09-08 12:24:53.753+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=3572154
09-08 12:24:53.753+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.basicgalleryex1)
09-08 12:24:53.763+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
09-08 12:24:53.763+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 860
09-08 12:24:53.773+0900 E/RESOURCED(  671): block.c: block_prelaunch_state(134) > insert data org.example.basicgalleryex1, table num : 8
09-08 12:24:53.773+0900 E/RESOURCED(  671): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-08 12:24:53.773+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
09-08 12:24:53.773+0900 W/AUL_PAD ( 1491): launchpad.c: __launchpad_main_loop(534) > Candidate is not prepared, enter legacy logic
09-08 12:24:53.773+0900 W/AUL_PAD ( 1491): launchpad.c: __send_result_to_caller(267) > Check app launching
09-08 12:24:53.773+0900 E/AUL_PAD ( 1491): launchpad.c: __send_result_to_caller(273) > launching failed
09-08 12:24:53.773+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3063) > Launch with legacy way : no launchpad
09-08 12:24:53.783+0900 W/AUL_AMD (  610): amd_launch.c: start_process(638) > child process: 5858
09-08 12:24:53.833+0900 W/AUL_AMD (  610): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 5858
09-08 12:24:53.833+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 5858, appid: org.example.basicgalleryex1
09-08 12:24:53.833+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
09-08 12:24:53.833+0900 E/RESOURCED(  671): proc-main.c: proc_add_program_list(237) > not found ppi : org.example.basicgalleryex1
09-08 12:24:53.843+0900 I/Tizen::App( 1250): (499) > LaunchedApp(org.example.basicgalleryex1)
09-08 12:24:53.843+0900 I/Tizen::App( 1250): (733) > Finished invoking application event listener for org.example.basicgalleryex1, 5858.
09-08 12:24:53.843+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(425) > request cmd(1) result(5858)
09-08 12:24:53.973+0900 E/EFL     (  610): ecore_x<610> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=3572376
09-08 12:24:53.983+0900 I/CAPI_APPFW_APPLICATION( 5858): app_main.c: ui_app_main(789) > app_efl_main
09-08 12:24:54.063+0900 E/EFL     (  610): ecore_x<610> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=3572464
09-08 12:24:54.314+0900 I/CAPI_APPFW_APPLICATION( 5858): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
09-08 12:24:54.364+0900 E/TBM     ( 5858): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
09-08 12:24:54.364+0900 I/MALI    ( 5858): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=5858   open drm_fd=36 
09-08 12:24:54.414+0900 I/UXT     ( 5853): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
09-08 12:24:54.644+0900 W/AUL_AMD (  610): amd_request.c: __send_app_termination_signal(609) > send dead signal done
09-08 12:24:54.644+0900 I/Tizen::App( 1250): (243) > App[org.example.basicgalleryex1] pid[5858] terminate event is forwarded
09-08 12:24:54.644+0900 I/Tizen::System( 1250): (256) > osp.accessorymanager.service provider is found.
09-08 12:24:54.644+0900 I/Tizen::System( 1250): (196) > Accessory Owner is removed [org.example.basicgalleryex1, 5858, ]
09-08 12:24:54.644+0900 I/Tizen::System( 1250): (256) > osp.system.service provider is found.
09-08 12:24:54.644+0900 I/Tizen::App( 1250): (506) > TerminatedApp(org.example.basicgalleryex1)
09-08 12:24:54.644+0900 I/Tizen::App( 1250): (512) > Not registered pid(5858)
09-08 12:24:54.644+0900 I/Tizen::System( 1250): (246) > Terminated app [org.example.basicgalleryex1]
09-08 12:24:54.644+0900 I/Tizen::Io( 1250): (729) > Entry not found
09-08 12:24:54.644+0900 I/ESD     (  880): esd_main.c: __esd_app_dead_handler(1773) > pid: 5858
09-08 12:24:54.654+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 5858
09-08 12:24:54.654+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 5858
09-08 12:24:54.654+0900 I/Tizen::System( 1250): (157) > change brightness system value.
09-08 12:24:54.654+0900 I/Tizen::App( 1250): (782) > Finished invoking application event listener for org.example.basicgalleryex1, 5858.
09-08 12:24:55.004+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=3573350
09-08 12:24:55.004+0900 E/cluster-view(  860): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
09-08 12:24:55.004+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=3573404
09-08 12:24:55.004+0900 E/cluster-view(  860): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
09-08 12:24:55.004+0900 W/cluster-home(  860): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
09-08 12:24:55.004+0900 W/cluster-home(  860): cluster-data-provider.cpp: OnMainScrollStarted(4739) >  Main Scroll Started Done
09-08 12:24:55.184+0900 W/cluster-home(  860): cluster-data-provider.cpp: OnMainScrollCompleted(4747) >  Main Scroll Completed
09-08 12:24:55.184+0900 W/cluster-home(  860): cluster-data-provider.cpp: OnMainScrollCompleted(4750) >  Main Scroll Completed Done
09-08 12:24:55.635+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=3574036
09-08 12:24:55.635+0900 E/cluster-view(  860): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86PowerOff]Key [Down]Event!! 
09-08 12:24:55.805+0900 I/AclService( 1394): AppManagerService.cpp: onScreenStateChange(1710) > Screen state change received by (ACL111OMWW)
09-08 12:24:55.805+0900 E/VOLUME  (  857): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-08 12:24:55.805+0900 E/VOLUME  (  857): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
09-08 12:24:55.815+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=3574204
09-08 12:24:55.825+0900 W/LOCKSCREEN(  842): dbus.c: _dbus_message_recv_cb(168) > [_dbus_message_recv_cb:168:W] PRE_LCD_OFF cause[powerkey] (status:3)
09-08 12:24:55.825+0900 W/LOCKSCREEN(  842): event.c: _lcd_off_cb(64) > [_lcd_off_cb:64:W] Dbus LCD off:powerkey
09-08 12:24:55.825+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30000:LCD_WILL_OFF
09-08 12:24:55.825+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:30000 event_info:0
09-08 12:24:55.825+0900 W/LOCKSCREEN(  842): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:3
09-08 12:24:55.825+0900 W/LOCKSCREEN(  842): daemon.c: _state_enter(378) > [_state_enter:378:W] HIDE => WILL RESUME
09-08 12:24:55.825+0900 W/APP_CORE(  860): appcore-efl.c: __cmsg_cb(1038) > LCD Off. Pause the topmost app
09-08 12:24:55.825+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
09-08 12:24:55.825+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-08 12:24:55.825+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
09-08 12:24:55.835+0900 E/LOCKSCREEN(  842): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-08 12:24:55.835+0900 E/LOCKSCREEN(  842): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
09-08 12:24:55.835+0900 E/LOCKSCREEN(  842): util-daemon.c: _lock_state_timer_cb(62) > [_lock_state_timer_cb:62:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LAUNCHING_LOCK ##########
09-08 12:24:55.835+0900 W/LOCKSCREEN(  842): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:5
09-08 12:24:55.835+0900 W/LOCKSCREEN(  842): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => WILL PAUSE
09-08 12:24:55.845+0900 W/AUL     (  842): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
09-08 12:24:55.845+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
09-08 12:24:55.845+0900 W/INDICATOR(  659): main.c: _indicator_lock_status_cb(418) > LockState is Lock, but Lockscreen invisible state
09-08 12:24:55.845+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 842
09-08 12:24:55.845+0900 I/AUL_AMD (  610): amd_launch.c: __check_app_control_privilege(1830) > Skip the privilege check in case of preloaded apps
09-08 12:24:55.855+0900 W/AUL_AMD (  610): amd_launch.c: start_process(638) > child process: 5885
09-08 12:24:55.855+0900 E/RESOURCED(  671): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-08 12:24:55.905+0900 W/AUL_AMD (  610): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 5885
09-08 12:24:55.905+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 5885, appid: com.samsung.weather-m-agent
09-08 12:24:55.905+0900 E/RESOURCED(  671): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.weather-m
09-08 12:24:55.915+0900 I/Tizen::App( 1250): (499) > LaunchedApp(com.samsung.weather-m-agent)
09-08 12:24:55.915+0900 I/Tizen::App( 1250): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 5885.
09-08 12:24:55.915+0900 W/AUL     (  842): launch.c: app_request_to_launchpad(425) > request cmd(0) result(5885)
09-08 12:24:55.915+0900 E/AUL     (  610): app_sock.c: __connect_client_sock(231) > connect error: 2
09-08 12:24:55.915+0900 E/AUL     (  610): app_sock.c: __create_client_sock(197) > cannot connect the client socket: 2
09-08 12:24:56.015+0900 E/AUL     (  610): app_sock.c: __connect_client_sock(231) > connect error: 2
09-08 12:24:56.015+0900 E/AUL     (  610): app_sock.c: __create_client_sock(197) > cannot connect the client socket: 2
09-08 12:24:56.055+0900 E/weather-agent( 5885): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
09-08 12:24:56.055+0900 E/weather-common( 5885): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
09-08 12:24:56.055+0900 E/weather-agent( 5885): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
09-08 12:24:56.055+0900 E/weather-agent( 5885): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.deco-app, PortID : lockscreen-message-port[0;m
09-08 12:24:56.065+0900 I/MESSAGE_PORT( 5885): message-port.c: __initialize(872) > initialize
09-08 12:24:56.075+0900 I/MESSAGE_PORT( 5885): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
09-08 12:24:56.205+0900 I/AclService( 1394): AppManagerService.cpp: onScreenStateChange(1710) > Screen state change received by (ACL111OMWW)
09-08 12:24:56.205+0900 E/VOLUME  (  857): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-08 12:24:56.205+0900 E/VOLUME  (  857): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
09-08 12:24:56.215+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
09-08 12:24:56.215+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: PAUSED
09-08 12:24:56.245+0900 E/EFL     (  330): eo<330> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-08 12:24:56.245+0900 E/EFL     (  330): eo<330> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-08 12:24:56.255+0900 I/Tizen::System( 1250): (259) > Active app [com.samsun], current [com.samsun] 
09-08 12:24:56.255+0900 I/Tizen::System( 1250): (273) > Current App[com.samsun] is already actived.
09-08 12:24:56.286+0900 I/MESSAGE_PORT( 5885): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-08 12:24:56.286+0900 I/MESSAGE_PORT( 5885): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-08 12:24:56.286+0900 I/MESSAGE_PORT( 5885): message-port.c: __message_port_send_message(972) > port exist check !!
09-08 12:24:56.286+0900 I/MESSAGE_PORT( 5885): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
09-08 12:24:56.286+0900 I/MESSAGE_PORT( 5885): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
09-08 12:24:56.286+0900 I/MESSAGE_PORT( 5885): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-08 12:24:56.286+0900 I/MESSAGE_PORT( 5885): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-08 12:24:56.286+0900 E/weather-common( 5885): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
09-08 12:24:56.296+0900 I/MESSAGE_PORT( 5885): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
09-08 12:24:56.296+0900 I/MESSAGE_PORT( 5885): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
09-08 12:24:56.296+0900 I/MESSAGE_PORT( 5885): message-port.c: __message_port_send_message(972) > port exist check !!
09-08 12:24:56.296+0900 I/MESSAGE_PORT( 5885): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.deco-app:lockscreen-message-port]
09-08 12:24:56.296+0900 I/MESSAGE_PORT( 5885): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.deco-app : com.samsung.weather-m-agent] 
09-08 12:24:56.296+0900 I/MESSAGE_PORT( 5885): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
09-08 12:24:56.296+0900 E/MESSAGE_PORT( 5885): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0
09-08 12:24:56.296+0900 E/weather-common( 5885): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(631) > [0;40;31mmessage_port_send_message failed [com.samsung.deco-app, lockscreen-message-port][0;m
09-08 12:24:56.296+0900 I/MESSAGE_PORT( 5885): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-08 12:24:56.296+0900 I/MESSAGE_PORT( 5885): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-08 12:24:56.296+0900 I/MESSAGE_PORT( 5885): message-port.c: __message_port_send_message(972) > port exist check !!
09-08 12:24:56.296+0900 I/MESSAGE_PORT( 5885): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
09-08 12:24:56.296+0900 I/MESSAGE_PORT( 5885): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
09-08 12:24:56.296+0900 I/MESSAGE_PORT( 5885): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-08 12:24:56.296+0900 E/MESSAGE_PORT( 5885): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
09-08 12:24:56.296+0900 E/weather-common( 5885): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
09-08 12:24:56.296+0900 I/MESSAGE_PORT( 5885): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-08 12:24:56.296+0900 I/MESSAGE_PORT( 5885): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-08 12:24:56.296+0900 I/MESSAGE_PORT( 5885): message-port.c: __message_port_send_message(972) > port exist check !!
09-08 12:24:56.296+0900 I/MESSAGE_PORT( 5885): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
09-08 12:24:56.296+0900 I/MESSAGE_PORT( 5885): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
09-08 12:24:56.296+0900 I/MESSAGE_PORT( 5885): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-08 12:24:56.296+0900 E/MESSAGE_PORT( 5885): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-08 12:24:56.296+0900 E/weather-common( 5885): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(644) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget, com.samsung.weather-m-widget.message.port.local][0;m
09-08 12:24:56.296+0900 I/MESSAGE_PORT( 5885): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-08 12:24:56.296+0900 I/MESSAGE_PORT( 5885): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-08 12:24:56.296+0900 I/MESSAGE_PORT( 5885): message-port.c: __message_port_send_message(972) > port exist check !!
09-08 12:24:56.296+0900 I/MESSAGE_PORT( 5885): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
09-08 12:24:56.296+0900 I/MESSAGE_PORT( 5885): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
09-08 12:24:56.296+0900 I/MESSAGE_PORT( 5885): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-08 12:24:56.296+0900 E/MESSAGE_PORT( 5885): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
09-08 12:24:56.296+0900 E/weather-common( 5885): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
09-08 12:24:56.296+0900 E/weather-common( 5885): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 0[0;m
09-08 12:24:56.296+0900 E/weather-common( 5885): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : 대전광역시[0;m
09-08 12:24:56.296+0900 E/weather-common( 5885): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : Daejeon[0;m
09-08 12:24:56.296+0900 E/weather-common( 5885): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : 28.900000[0;m
09-08 12:24:56.296+0900 E/weather-common( 5885): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : 30.500000[0;m
09-08 12:24:56.296+0900 E/weather-common( 5885): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : 70.300000[0;m
09-08 12:24:56.296+0900 E/weather-common( 5885): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : 2[0;m
09-08 12:24:56.296+0900 E/weather-common( 5885): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : 1472959134[0;m
09-08 12:24:56.296+0900 E/weather-common( 5885): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
09-08 12:24:56.296+0900 E/weather-common( 5885): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
09-08 12:24:56.296+0900 E/weather-agent( 5885): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
09-08 12:24:56.296+0900 E/weather-agent( 5885): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
09-08 12:24:56.296+0900 I/MESSAGE_PORT( 5885): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-08 12:24:56.316+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
09-08 12:24:56.326+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(842) status(3)
09-08 12:24:56.326+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-08 12:24:56.326+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
09-08 12:24:56.326+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.lockscreen(842)
09-08 12:24:56.326+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 842, appid: com.samsung.lockscreen, status: fg
09-08 12:24:56.326+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
09-08 12:24:56.326+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
09-08 12:24:56.326+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
09-08 12:24:56.336+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(842) status(0)
09-08 12:24:56.376+0900 I/MESSAGE_PORT(  842): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
09-08 12:24:56.376+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
09-08 12:24:56.396+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:1:LOCK
09-08 12:24:56.396+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:1 event_info:0
09-08 12:24:56.396+0900 E/LOCKSCREEN(  842): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
09-08 12:24:56.396+0900 W/LOCKSCREEN(  842): view-mgr.c: _event_route(130) > [_event_route:130:W] event:1 event_info:0
09-08 12:24:56.396+0900 W/LOCKSCREEN(  842): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2E00007] is [visible]
09-08 12:24:56.396+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10001:WIN_BECOME_VISIBLE
09-08 12:24:56.396+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:10001 event_info:0
09-08 12:24:56.396+0900 W/INDICATOR(  659): main.c: _indicator_lock_status_cb(418) > LockState is Lock, but Lockscreen invisible state
09-08 12:24:56.396+0900 E/LOCKSCREEN(  842): util-daemon.c: _lock_state_timer_cb(59) > [_lock_state_timer_cb:59:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LOCK ##########
09-08 12:24:56.396+0900 W/APP_CORE(  842): appcore-efl.c: __visibility_cb(989) > LCD status is off, skip the AE_RESUME event
09-08 12:24:56.396+0900 W/INDICATOR(  659): main.c: _indicator_lock_status_cb(413) > Hide Clock
09-08 12:24:56.396+0900 E/LOCKSCREEN(  842): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
09-08 12:24:56.396+0900 E/LOCKSCREEN(  842): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
09-08 12:24:56.396+0900 E/LOCKSCREEN(  842): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-08 12:24:56.396+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
09-08 12:24:56.396+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
09-08 12:24:56.396+0900 W/LOCKSCREEN(  842): dbus.c: _dbus_message_recv_cb(179) > [_dbus_message_recv_cb:179:W] POST_LCD_OFF status 4 visibility(1)
09-08 12:24:56.396+0900 W/LOCKSCREEN(  842): event.c: _lcd_off_completed_cb(48) > [_lcd_off_completed_cb:48:W] Vconf LCD off
09-08 12:24:56.396+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30002:LCD_OFF
09-08 12:24:56.396+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:30002 event_info:0
09-08 12:24:56.396+0900 W/LOCKSCREEN(  842): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:6
09-08 12:24:56.396+0900 W/LOCKSCREEN(  842): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL PAUSE => PAUSE
09-08 12:24:57.046+0900 W/CRASH_MANAGER( 5761): worker.c: worker_job(1199) > 1105832626173147330509
