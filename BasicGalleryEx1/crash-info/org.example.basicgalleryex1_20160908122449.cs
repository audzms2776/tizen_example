S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPD4
Build-Date: 2016.04.11 14:59:15

Crash Information
Process Name: basicgalleryex1
PID: 5770
Date: 2016-09-08 12:24:49+0900
Executable File Path: /opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 5770, uid 5000)

Register Information
r0   = 0x80008c47, r1   = 0xbef1a3c4
r2   = 0x80008c47, r3   = 0xb3f3c000
r4   = 0xb3ffda3c, r5   = 0xbef1b4d4
r6   = 0x00000001, r7   = 0xbef1b3e0
r8   = 0xbef1b4c8, r9   = 0xb88ab718
r10  = 0xbef1b4e8, fp   = 0x00000000
ip   = 0xb600e120, sp   = 0xbef1a380
lr   = 0xb283159d, pc   = 0xb28316b2
cpsr = 0x80000030

Memory Information
MemTotal:   987012 KB
MemFree:     83172 KB
Buffers:     25368 KB
Cached:     260252 KB
VmPeak:      89176 KB
VmSize:      89172 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19020 KB
VmRSS:       19020 KB
VmData:      22000 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35620 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 5770 TID = 5770
5770 5775 5818 

Maps Information
b1cff000 b1d07000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1d18000 b1d19000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1d29000 b1d3d000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1d51000 b1d52000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1d62000 b1d65000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1d76000 b1d77000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1d87000 b1d89000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1d99000 b1d9b000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1dab000 b1dbb000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1dcb000 b1dd7000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1de9000 b25e8000 rw-p [stack:5818]
b27e8000 b27ef000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2800000 b2808000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b281a000 b2820000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2830000 b2832000 r-xp /opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1
b2982000 b2a65000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a9c000 b2ac4000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2ad6000 b32d5000 rw-p [stack:5775]
b32d5000 b32d7000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32e7000 b32f1000 r-xp /lib/libnss_files-2.20-2014.11.so
b3302000 b330b000 r-xp /lib/libnss_nis-2.20-2014.11.so
b331c000 b332d000 r-xp /lib/libnsl-2.20-2014.11.so
b3340000 b3346000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3357000 b3358000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3380000 b3387000 r-xp /usr/lib/libminizip.so.1.0.0
b3397000 b339c000 r-xp /usr/lib/libstorage.so.0.1
b33ac000 b340b000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3421000 b3435000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3445000 b3489000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3499000 b34a1000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34b1000 b34e1000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34f4000 b35ad000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35c1000 b3614000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3625000 b3640000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3650000 b3711000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3724000 b3734000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3744000 b3751000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3762000 b3769000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3779000 b37ba000 r-xp /usr/lib/libmdm.so.1.2.12
b37ca000 b37d2000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37e1000 b37f1000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3812000 b3872000 r-xp /usr/lib/libasound.so.2.0.0
b3884000 b3887000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3897000 b389a000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38aa000 b38af000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38bf000 b38c0000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38d0000 b38db000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38ef000 b38f6000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3906000 b390c000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b391c000 b3921000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3931000 b394c000 r-xp /usr/lib/libmmfsound.so.0.1.0
b395c000 b3963000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3973000 b3976000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3987000 b39b5000 r-xp /usr/lib/libidn.so.11.5.44
b39c5000 b39db000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39ec000 b39f6000 r-xp /usr/lib/libcares.so.2.1.0
b3a06000 b3a10000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a20000 b3a22000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a32000 b3a33000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a43000 b3a47000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a58000 b3a80000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a91000 b3aba000 r-xp /usr/lib/libturbojpeg.so
b3ada000 b3ae0000 r-xp /usr/lib/libgif.so.4.1.6
b3af0000 b3b36000 r-xp /usr/lib/libcurl.so.4.3.0
b3b47000 b3b68000 r-xp /usr/lib/libexif.so.12.3.3
b3b83000 b3b98000 r-xp /usr/lib/libtts.so
b3ba9000 b3bb1000 r-xp /usr/lib/libfeedback.so.0.1.4
b3bc1000 b3c87000 r-xp /usr/lib/libdali-core.so.0.0.0
b3ca7000 b3d9f000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3dbe000 b3e8c000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3ea3000 b3ea5000 r-xp /usr/lib/libboost_system.so.1.51.0
b3eb5000 b3ebb000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3ecb000 b3eee000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3eff000 b3f01000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f11000 b3f13000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f24000 b3f29000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f40000 b3f42000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f52000 b3f59000 r-xp /usr/lib/libsensord-share.so
b3f69000 b3f81000 r-xp /usr/lib/libsensor.so.1.1.0
b3f92000 b3f95000 r-xp /usr/lib/libXv.so.1.0.0
b3fa5000 b3faa000 r-xp /usr/lib/libutilX.so.1.1.0
b3fba000 b3fbf000 r-xp /usr/lib/libappcore-common.so.1.1
b3fcf000 b3fd6000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fe9000 b3fed000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3ffe000 b40dc000 r-xp /usr/lib/libCOREGL.so.4.0
b40fc000 b40ff000 r-xp /usr/lib/libuuid.so.1.3.0
b410f000 b4126000 r-xp /usr/lib/libblkid.so.1.1.0
b4137000 b4139000 r-xp /usr/lib/libXau.so.6.0.0
b4149000 b4190000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41a2000 b41a8000 r-xp /usr/lib/libjson-c.so.2.0.1
b41b9000 b41bd000 r-xp /usr/lib/libogg.so.0.7.1
b41cd000 b41ef000 r-xp /usr/lib/libvorbis.so.0.4.3
b41ff000 b42e3000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42ff000 b4302000 r-xp /usr/lib/libEGL.so.1.4
b4313000 b4319000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4329000 b432b000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b433b000 b4348000 r-xp /usr/lib/libGLESv2.so.2.0
b4359000 b43bb000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43d0000 b43e8000 r-xp /usr/lib/libmount.so.1.1.0
b43fa000 b440e000 r-xp /usr/lib/libxcb.so.1.1.0
b441e000 b4425000 r-xp /lib/libcrypt-2.20-2014.11.so
b445d000 b445f000 r-xp /usr/lib/libiri.so
b446f000 b447a000 r-xp /usr/lib/libgpg-error.so.0.15.0
b448b000 b44c1000 r-xp /usr/lib/libpulse.so.0.16.2
b44d2000 b4515000 r-xp /usr/lib/libsndfile.so.1.0.25
b452a000 b453f000 r-xp /lib/libexpat.so.1.5.2
b4551000 b460f000 r-xp /usr/lib/libcairo.so.2.11200.14
b4623000 b462b000 r-xp /usr/lib/libdrm.so.2.4.0
b463b000 b463e000 r-xp /usr/lib/libdri2.so.0.0.0
b464e000 b469c000 r-xp /usr/lib/libssl.so.1.0.0
b46b1000 b46bd000 r-xp /usr/lib/libeeze.so.1.13.0
b46ce000 b46d7000 r-xp /usr/lib/libethumb.so.1.13.0
b46e7000 b46ea000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46fa000 b48b1000 r-xp /usr/lib/libcrypto.so.1.0.0
b569c000 b56a5000 r-xp /usr/lib/libXi.so.6.1.0
b56b5000 b56b7000 r-xp /usr/lib/libXgesture.so.7.0.0
b56c7000 b56cb000 r-xp /usr/lib/libXtst.so.6.1.0
b56db000 b56e1000 r-xp /usr/lib/libXrender.so.1.3.0
b56f1000 b56f7000 r-xp /usr/lib/libXrandr.so.2.2.0
b5707000 b5709000 r-xp /usr/lib/libXinerama.so.1.0.0
b571a000 b571d000 r-xp /usr/lib/libXfixes.so.3.1.0
b572d000 b5738000 r-xp /usr/lib/libXext.so.6.4.0
b5748000 b574a000 r-xp /usr/lib/libXdamage.so.1.1.0
b575a000 b575c000 r-xp /usr/lib/libXcomposite.so.1.0.0
b576c000 b584e000 r-xp /usr/lib/libX11.so.6.3.0
b5862000 b5869000 r-xp /usr/lib/libXcursor.so.1.0.2
b5879000 b5891000 r-xp /usr/lib/libudev.so.1.6.0
b5893000 b5896000 r-xp /lib/libattr.so.1.1.0
b58a6000 b58c6000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58c7000 b58cc000 r-xp /usr/lib/libffi.so.6.0.2
b58dd000 b58f5000 r-xp /lib/libz.so.1.2.8
b5905000 b5907000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5917000 b59ec000 r-xp /usr/lib/libxml2.so.2.9.2
b5a01000 b5a9c000 r-xp /usr/lib/libstdc++.so.6.0.20
b5ab8000 b5abb000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5acb000 b5ae4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5af5000 b5b06000 r-xp /lib/libresolv-2.20-2014.11.so
b5b1a000 b5b94000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5ba9000 b5bab000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bbb000 b5bc2000 r-xp /usr/lib/libembryo.so.1.13.0
b5bd2000 b5bdc000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5bed000 b5c05000 r-xp /usr/lib/libpng12.so.0.50.0
b5c16000 b5c39000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c5a000 b5c6e000 r-xp /usr/lib/libector.so.1.13.0
b5c7f000 b5c97000 r-xp /usr/lib/liblua-5.1.so
b5ca8000 b5cff000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d13000 b5d3b000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d4c000 b5d5f000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d70000 b5daa000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5dbb000 b5dc9000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5dd9000 b5de1000 r-xp /usr/lib/libtbm.so.1.0.0
b5df1000 b5dfe000 r-xp /usr/lib/libeio.so.1.13.0
b5e0e000 b5e10000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e20000 b5e25000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e35000 b5e4c000 r-xp /usr/lib/libefreet.so.1.13.0
b5e5e000 b5e7e000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e8e000 b5eae000 r-xp /usr/lib/libecore_con.so.1.13.0
b5eb0000 b5eb6000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ec6000 b5ed7000 r-xp /usr/lib/libemotion.so.1.13.0
b5ee8000 b5eef000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5eff000 b5f0e000 r-xp /usr/lib/libeo.so.1.13.0
b5f1f000 b5f31000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f42000 b5f47000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f57000 b5f70000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f80000 b5f9d000 r-xp /usr/lib/libeet.so.1.13.0
b5fb6000 b5ffe000 r-xp /usr/lib/libeina.so.1.13.0
b600f000 b601f000 r-xp /usr/lib/libefl.so.1.13.0
b6030000 b6115000 r-xp /usr/lib/libicuuc.so.51.1
b6132000 b6272000 r-xp /usr/lib/libicui18n.so.51.1
b6289000 b62c1000 r-xp /usr/lib/libecore_x.so.1.13.0
b62d3000 b62d6000 r-xp /lib/libcap.so.2.21
b62e6000 b630f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6320000 b6327000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6339000 b6370000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6381000 b646c000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b647f000 b64f8000 r-xp /usr/lib/libsqlite3.so.0.8.6
b650a000 b650f000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b651f000 b6529000 r-xp /usr/lib/libvconf.so.0.2.45
b6539000 b653b000 r-xp /usr/lib/libvasum.so.0.3.1
b654b000 b654d000 r-xp /usr/lib/libttrace.so.1.1
b655d000 b6560000 r-xp /usr/lib/libiniparser.so.0
b6570000 b6596000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65a6000 b65ab000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65bc000 b65d3000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65e4000 b664f000 r-xp /lib/libm-2.20-2014.11.so
b6660000 b6666000 r-xp /lib/librt-2.20-2014.11.so
b6677000 b6684000 r-xp /usr/lib/libunwind.so.8.0.1
b66ba000 b67de000 r-xp /lib/libc-2.20-2014.11.so
b67f3000 b680c000 r-xp /lib/libgcc_s-4.9.so.1
b681c000 b68fe000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b690f000 b6939000 r-xp /usr/lib/libdbus-1.so.3.8.12
b694a000 b6986000 r-xp /usr/lib/libsystemd.so.0.4.0
b6988000 b6a0b000 r-xp /usr/lib/libedje.so.1.13.0
b6a1e000 b6a3c000 r-xp /usr/lib/libecore.so.1.13.0
b6a5c000 b6be3000 r-xp /usr/lib/libevas.so.1.13.0
b6c18000 b6c2c000 r-xp /lib/libpthread-2.20-2014.11.so
b6c40000 b6e74000 r-xp /usr/lib/libelementary.so.1.13.0
b6ea3000 b6ea7000 r-xp /usr/lib/libsmack.so.1.0.0
b6eb7000 b6ebe000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ece000 b6ed0000 r-xp /usr/lib/libdlog.so.0.0.0
b6ee0000 b6ee3000 r-xp /usr/lib/libbundle.so.0.1.22
b6ef3000 b6ef5000 r-xp /lib/libdl-2.20-2014.11.so
b6f06000 b6f1e000 r-xp /usr/lib/libaul.so.0.1.0
b6f32000 b6f37000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f48000 b6f55000 r-xp /usr/lib/liblptcp.so
b6f67000 b6f6b000 r-xp /usr/lib/libsys-assert.so
b6f7c000 b6f9c000 r-xp /lib/ld-2.20-2014.11.so
b6fad000 b6fb2000 r-xp /usr/bin/launchpad-loader
b8849000 b8a89000 rw-p [heap]
beefb000 bef1c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5770)
Call Stack Count: 10
 0: create_gengrid + 0x11 (0xb28316b2) [/opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1] + 0x16b2
 1: create_base_gui + 0x130 (0xb283159d) [/opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1] + 0x159d
 2: app_create + 0x12 (0xb28313ab) [/opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1] + 0x13ab
 3: (0xb3feb4f9) [/usr/lib/libcapi-appfw-application.so.0] + 0x24f9
 4: appcore_efl_main + 0x152 (0xb6f35203) [/usr/lib/libappcore-efl.so.1] + 0x3203
 5: ui_app_main + 0xc0 (0xb3feb909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
 6: main + 0x122 (0xb2831333) [/opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1] + 0x1333
 7: (0xb6faebb5) [/opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1] + 0x1bb5
 8: __libc_start_main + 0x114 (0xb66d04bc) [/lib/libc.so.6] + 0x164bc
 9: (0xb6faeeb4) [/opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1] + 0x1eb4
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
  610): amd_request.c: __request_handler(906) > __request_handler: 0
09-08 12:24:04.195+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 842
09-08 12:24:04.195+0900 I/AUL_AMD (  610): amd_launch.c: __check_app_control_privilege(1830) > Skip the privilege check in case of preloaded apps
09-08 12:24:04.215+0900 E/RESOURCED(  671): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-08 12:24:04.215+0900 W/AUL_AMD (  610): amd_launch.c: start_process(638) > child process: 5628
09-08 12:24:04.265+0900 W/AUL_AMD (  610): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 5628
09-08 12:24:04.265+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 5628, appid: com.samsung.weather-m-agent
09-08 12:24:04.275+0900 W/AUL     (  842): launch.c: app_request_to_launchpad(425) > request cmd(0) result(5628)
09-08 12:24:04.275+0900 E/AUL     (  610): app_sock.c: __connect_client_sock(231) > connect error: 2
09-08 12:24:04.275+0900 E/AUL     (  610): app_sock.c: __create_client_sock(197) > cannot connect the client socket: 2
09-08 12:24:04.285+0900 E/RESOURCED(  671): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.weather-m
09-08 12:24:04.295+0900 I/Tizen::App( 1250): (499) > LaunchedApp(com.samsung.weather-m-agent)
09-08 12:24:04.295+0900 I/Tizen::App( 1250): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 5628.
09-08 12:24:04.375+0900 E/AUL     (  610): app_sock.c: __connect_client_sock(231) > connect error: 2
09-08 12:24:04.375+0900 E/AUL     (  610): app_sock.c: __create_client_sock(197) > cannot connect the client socket: 2
09-08 12:24:04.445+0900 E/weather-agent( 5628): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
09-08 12:24:04.445+0900 E/weather-common( 5628): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
09-08 12:24:04.445+0900 E/weather-agent( 5628): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
09-08 12:24:04.445+0900 E/weather-agent( 5628): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.deco-app, PortID : lockscreen-message-port[0;m
09-08 12:24:04.465+0900 I/MESSAGE_PORT( 5628): message-port.c: __initialize(872) > initialize
09-08 12:24:04.475+0900 I/MESSAGE_PORT( 5628): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
09-08 12:24:04.495+0900 I/MESSAGE_PORT( 5628): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-08 12:24:04.495+0900 I/MESSAGE_PORT( 5628): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-08 12:24:04.495+0900 I/MESSAGE_PORT( 5628): message-port.c: __message_port_send_message(972) > port exist check !!
09-08 12:24:04.495+0900 I/MESSAGE_PORT( 5628): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
09-08 12:24:04.495+0900 I/MESSAGE_PORT( 5628): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
09-08 12:24:04.495+0900 I/MESSAGE_PORT( 5628): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-08 12:24:04.505+0900 I/MESSAGE_PORT( 5628): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-08 12:24:04.505+0900 E/weather-common( 5628): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
09-08 12:24:04.505+0900 I/MESSAGE_PORT(  842): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
09-08 12:24:04.505+0900 I/MESSAGE_PORT( 5628): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
09-08 12:24:04.505+0900 I/MESSAGE_PORT( 5628): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
09-08 12:24:04.505+0900 I/MESSAGE_PORT( 5628): message-port.c: __message_port_send_message(972) > port exist check !!
09-08 12:24:04.505+0900 I/MESSAGE_PORT( 5628): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.deco-app:lockscreen-message-port]
09-08 12:24:04.505+0900 I/MESSAGE_PORT( 5628): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.deco-app : com.samsung.weather-m-agent] 
09-08 12:24:04.505+0900 I/MESSAGE_PORT( 5628): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
09-08 12:24:04.505+0900 E/MESSAGE_PORT( 5628): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0
09-08 12:24:04.505+0900 E/weather-common( 5628): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(631) > [0;40;31mmessage_port_send_message failed [com.samsung.deco-app, lockscreen-message-port][0;m
09-08 12:24:04.505+0900 I/MESSAGE_PORT( 5628): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-08 12:24:04.505+0900 I/MESSAGE_PORT( 5628): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-08 12:24:04.505+0900 I/MESSAGE_PORT( 5628): message-port.c: __message_port_send_message(972) > port exist check !!
09-08 12:24:04.505+0900 I/MESSAGE_PORT( 5628): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
09-08 12:24:04.505+0900 I/MESSAGE_PORT( 5628): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
09-08 12:24:04.505+0900 I/MESSAGE_PORT( 5628): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-08 12:24:04.505+0900 E/MESSAGE_PORT( 5628): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
09-08 12:24:04.505+0900 E/weather-common( 5628): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
09-08 12:24:04.505+0900 I/MESSAGE_PORT( 5628): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-08 12:24:04.505+0900 I/MESSAGE_PORT( 5628): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-08 12:24:04.505+0900 I/MESSAGE_PORT( 5628): message-port.c: __message_port_send_message(972) > port exist check !!
09-08 12:24:04.505+0900 I/MESSAGE_PORT( 5628): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
09-08 12:24:04.505+0900 I/MESSAGE_PORT( 5628): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
09-08 12:24:04.505+0900 I/MESSAGE_PORT( 5628): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-08 12:24:04.505+0900 E/MESSAGE_PORT( 5628): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-08 12:24:04.505+0900 E/weather-common( 5628): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(644) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget, com.samsung.weather-m-widget.message.port.local][0;m
09-08 12:24:04.505+0900 I/MESSAGE_PORT( 5628): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-08 12:24:04.505+0900 I/MESSAGE_PORT( 5628): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-08 12:24:04.505+0900 I/MESSAGE_PORT( 5628): message-port.c: __message_port_send_message(972) > port exist check !!
09-08 12:24:04.505+0900 I/MESSAGE_PORT( 5628): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
09-08 12:24:04.505+0900 I/MESSAGE_PORT( 5628): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
09-08 12:24:04.505+0900 I/MESSAGE_PORT( 5628): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-08 12:24:04.505+0900 E/MESSAGE_PORT( 5628): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
09-08 12:24:04.505+0900 E/weather-common( 5628): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
09-08 12:24:04.505+0900 E/weather-common( 5628): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 0[0;m
09-08 12:24:04.505+0900 E/weather-common( 5628): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : 대전광역시[0;m
09-08 12:24:04.505+0900 E/weather-common( 5628): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : Daejeon[0;m
09-08 12:24:04.505+0900 E/weather-common( 5628): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : 28.900000[0;m
09-08 12:24:04.505+0900 E/weather-common( 5628): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : 30.500000[0;m
09-08 12:24:04.505+0900 E/weather-common( 5628): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : 70.300000[0;m
09-08 12:24:04.505+0900 E/weather-common( 5628): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : 2[0;m
09-08 12:24:04.505+0900 E/weather-common( 5628): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : 1472959134[0;m
09-08 12:24:04.505+0900 E/weather-common( 5628): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
09-08 12:24:04.505+0900 E/weather-common( 5628): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
09-08 12:24:04.515+0900 E/weather-agent( 5628): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
09-08 12:24:04.515+0900 E/weather-agent( 5628): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
09-08 12:24:04.515+0900 I/MESSAGE_PORT( 5628): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-08 12:24:04.595+0900 I/AclService( 1394): AppManagerService.cpp: onScreenStateChange(1710) > Screen state change received by (ACL111OMWW)
09-08 12:24:04.595+0900 I/Tizen::System( 1250): (280) > The screen has been turned on.
09-08 12:24:04.595+0900 I/Tizen::Io( 1250): (729) > Entry not found
09-08 12:24:04.605+0900 I/Tizen::System( 1250): (157) > change brightness system value.
09-08 12:24:04.615+0900 D/RILJ    ( 1690): [3661]> SCREEN_STATE: true
09-08 12:24:04.615+0900 D/RilRequest( 1690): [3661]< SCREEN_STATE error: com.android.internal.telephony.CommandException: RADIO_NOT_AVAILABLE ret=
09-08 12:24:04.615+0900 D/DCT     ( 1690): onReceive: action=android.intent.action.SCREEN_ON
09-08 12:24:04.615+0900 D/DCT     ( 1690): stopNetStatPoll
09-08 12:24:04.615+0900 D/DCT     ( 1690): overall state is IDLE
09-08 12:24:04.685+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
09-08 12:24:04.705+0900 W/LOCKSCREEN(  842): dbus.c: _dbus_message_recv_cb(154) > [_dbus_message_recv_cb:154:W] POST_LCD_ON status 2 visibility(1)
09-08 12:24:05.076+0900 W/ProcessCpuTracker( 1568): Skipping unknown process pid 5627
09-08 12:24:05.086+0900 W/ProcessCpuTracker( 1568): Skipping unknown process pid 5628
09-08 12:24:05.086+0900 W/ProcessCpuTracker( 1568): Skipping unknown process pid 5630
09-08 12:24:05.166+0900 D/dalvikvm( 1568): GC_CONCURRENT freed 578K, 12% free 5969K/6744K, paused 8ms+15ms, total 84ms
09-08 12:24:05.216+0900 E/EFL     (  842): ecore_x<842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=3523614
09-08 12:24:05.366+0900 E/EFL     (  842): ecore_x<842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=3523769
09-08 12:24:05.376+0900 E/LOCKSCREEN(  842): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
09-08 12:24:05.376+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80001:VIEW_GESTURED
09-08 12:24:05.376+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:80001 event_info:0
09-08 12:24:05.376+0900 W/LOCKSCREEN(  842): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
09-08 12:24:05.376+0900 W/LOCKSCREEN(  842): view-mgr.c: _event_route(130) > [_event_route:130:W] event:80001 event_info:0
09-08 12:24:05.376+0900 W/LOCKSCREEN(  842): view-mgr.c: _state_transit(46) > [_state_transit:46:W] state transit:2
09-08 12:24:05.376+0900 W/LOCKSCREEN(  842): view-mgr.c: _state_transit(49) > [_state_transit:49:W] already in same state:2
09-08 12:24:05.376+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:4:LKD_EVT_WILL_UNLOCK
09-08 12:24:05.376+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:4 event_info:0
09-08 12:24:05.376+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event_delay(1041) > [lockd_event_delay:1041:W] dealyed event:2:UNLOCK wait for:0.330000
09-08 12:24:05.376+0900 E/LOCKSCREEN(  842): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
09-08 12:24:05.516+0900 E/weather-agent( 5628): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
09-08 12:24:05.516+0900 I/CAPI_APPFW_APPLICATION( 5628): service_app_main.c: service_app_exit(446) > service_app_exit
09-08 12:24:05.526+0900 E/weather-agent( 5628): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
09-08 12:24:05.526+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
09-08 12:24:05.526+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
09-08 12:24:05.696+0900 W/AUL_AMD (  610): amd_request.c: __send_app_termination_signal(609) > send dead signal done
09-08 12:24:05.706+0900 I/ESD     (  880): esd_main.c: __esd_app_dead_handler(1773) > pid: 5628
09-08 12:24:05.706+0900 I/Tizen::App( 1250): (243) > App[com.samsung.weather-m-agent] pid[5628] terminate event is forwarded
09-08 12:24:05.706+0900 I/Tizen::System( 1250): (256) > osp.accessorymanager.service provider is found.
09-08 12:24:05.706+0900 I/Tizen::System( 1250): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 5628, ]
09-08 12:24:05.706+0900 I/Tizen::System( 1250): (256) > osp.system.service provider is found.
09-08 12:24:05.706+0900 I/Tizen::App( 1250): (506) > TerminatedApp(com.samsung.weather-m-agent)
09-08 12:24:05.706+0900 I/Tizen::App( 1250): (512) > Not registered pid(5628)
09-08 12:24:05.706+0900 I/Tizen::System( 1250): (246) > Terminated app [com.samsung.weather-m-agent]
09-08 12:24:05.706+0900 I/Tizen::Io( 1250): (729) > Entry not found
09-08 12:24:05.716+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 5628
09-08 12:24:05.716+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:2 event_info:0
09-08 12:24:05.716+0900 W/LOCKSCREEN(  842): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:7
09-08 12:24:05.716+0900 W/LOCKSCREEN(  842): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => HIDE
09-08 12:24:05.716+0900 E/LOCKSCREEN(  842): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
09-08 12:24:05.716+0900 E/LOCKSCREEN(  842): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
09-08 12:24:05.716+0900 E/LOCKSCREEN(  842): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-08 12:24:05.716+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
09-08 12:24:05.716+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
09-08 12:24:05.716+0900 W/LOCKSCREEN(  842): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
09-08 12:24:05.716+0900 I/Tizen::System( 1250): (157) > change brightness system value.
09-08 12:24:05.716+0900 I/Tizen::App( 1250): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 5628.
09-08 12:24:05.726+0900 E/EFL     (  330): eo<330> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-08 12:24:05.736+0900 W/LOCKSCREEN(  842): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2E00007] is [invisible]
09-08 12:24:05.736+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10002:WIN_BECOME_INVISIBLE
09-08 12:24:05.736+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:10002 event_info:0
09-08 12:24:05.736+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(842) status(4)
09-08 12:24:05.736+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.lockscreen(842)
09-08 12:24:05.736+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 842, appid: com.samsung.lockscreen, status: bg
09-08 12:24:05.736+0900 E/LOCKSCREEN(  842): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
09-08 12:24:05.736+0900 I/APP_CORE(  842): appcore-efl.c: __do_app(514) > [APP 842] Event: PAUSE State: RUNNING
09-08 12:24:05.736+0900 I/CAPI_APPFW_APPLICATION(  842): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-08 12:24:05.736+0900 E/LOCKSCREEN(  842): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-08 12:24:05.736+0900 E/LOCKSCREEN(  842): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
09-08 12:24:05.736+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20002:APP_PAUSE
09-08 12:24:05.736+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:20002 event_info:0
09-08 12:24:05.736+0900 W/LOCKSCREEN(  842): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
09-08 12:24:05.736+0900 E/LOCKSCREEN(  842): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
09-08 12:24:05.736+0900 E/EFL     (  330): eo<330> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-08 12:24:05.746+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(5497) status(3)
09-08 12:24:05.746+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-08 12:24:05.746+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
09-08 12:24:05.746+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.basicgenlustex1(5497)
09-08 12:24:05.746+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 5497, appid: org.example.basicgenlustex1, status: fg
09-08 12:24:05.776+0900 I/APP_CORE( 5497): appcore-efl.c: __do_app(514) > [APP 5497] Event: RESUME State: PAUSED
09-08 12:24:05.776+0900 I/CAPI_APPFW_APPLICATION( 5497): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-08 12:24:05.786+0900 I/Tizen::System( 1250): (259) > Active app [org.exampl], current [com.samsun] 
09-08 12:24:05.786+0900 I/Tizen::Io( 1250): (729) > Entry not found
09-08 12:24:05.796+0900 I/APP_CORE(  842): appcore-efl.c: __do_app(514) > [APP 842] Event: MEM_FLUSH State: PAUSED
09-08 12:24:05.796+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
09-08 12:24:05.796+0900 I/Tizen::System( 1250): (157) > change brightness system value.
09-08 12:24:05.836+0900 W/LOCKSCREEN(  842): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
09-08 12:24:05.836+0900 E/LOCKSCREEN(  842): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
09-08 12:24:05.836+0900 E/LOCKSCREEN(  842): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-08 12:24:05.836+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
09-08 12:24:05.836+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
09-08 12:24:08.619+0900 E/PKGMGR  ( 5685): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
09-08 12:24:08.699+0900 E/PKGMGR_SERVER( 5687): pkgmgr-server.c: main(2414) > package manager server start
09-08 12:24:08.749+0900 E/PKGMGR_SERVER( 5687): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.basicgalleryex1-1.0.0-arm.tpk]
09-08 12:24:08.759+0900 E/PKGMGR_INFO( 5687): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.basicgalleryex1-1.0.0-arm.tpk] not found in DB
09-08 12:24:08.769+0900 E/rpm-installer( 5687): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
09-08 12:24:08.779+0900 E/PKGMGR_SERVER( 5687): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
09-08 12:24:08.779+0900 E/PKGMGR_SERVER( 5687): pkgmgr-server.c: __set_recovery_mode(234) > rev_file[/opt/share/packages/.recovery/pkgmgr/org.example.basicgalleryex1-1.0.0-arm.tpk] is null
09-08 12:24:08.779+0900 E/PKGMGR  ( 5685): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[56850002]
09-08 12:24:08.899+0900 E/PKGMGR_INSTALLER( 5690): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
09-08 12:24:08.899+0900 E/rpm-installer( 5690): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.basicgalleryex1-1.0.0-arm.tpk] is tpk package.
09-08 12:24:08.919+0900 E/rpm-installer( 5690): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
09-08 12:24:08.919+0900 E/rpm-installer( 5690): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
09-08 12:24:08.919+0900 E/rpm-installer( 5690): coretpk-parser.c: __coretpk_parser_get_value_list(1104) > (ret == 1) [//*[name() ='privileges']/*[name()='privilege']] is empty.
09-08 12:24:08.919+0900 E/rpm-installer( 5690): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
09-08 12:24:08.919+0900 E/rpm-installer( 5690): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
09-08 12:24:08.919+0900 E/rpm-installer( 5690): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
09-08 12:24:08.979+0900 W/CERT_SVC_VCORE( 5690): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
09-08 12:24:09.029+0900 I/Tizen::App( 1250): (1894) > PackageEventHandler - req: 12500002, pkg_type: tpk, pkg_name: org.example.basicgalleryex1, key: start, val: install
09-08 12:24:09.029+0900 I/Tizen::App( 1250): (1584) > Package = [org.example.basicgalleryex1], Key = [start], Value = [install], install = [1]
09-08 12:24:09.029+0900 E/PKGMGR  ( 1551): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-08 12:24:09.029+0900 E/PKGMGR  ( 1551): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-08 12:24:09.039+0900 I/Tizen::App( 1250): (1894) > PackageEventHandler - req: 12500002, pkg_type: tpk, pkg_name: org.example.basicgalleryex1, key: install_percent, val: 30
09-08 12:24:09.039+0900 I/Tizen::App( 1250): (119) > InstallationInProgress [30]
09-08 12:24:09.039+0900 I/Tizen::App( 1250): (1584) > Package = [org.example.basicgalleryex1], Key = [install_percent], Value = [30], install = [1]
09-08 12:24:09.049+0900 E/PKGMGR  ( 1551): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-08 12:24:09.049+0900 E/PKGMGR  ( 1551): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-08 12:24:09.640+0900 E/rpm-installer( 5690): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
09-08 12:24:09.640+0900 E/rpm-installer( 5690): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
09-08 12:24:09.640+0900 E/rpm-installer( 5690): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
09-08 12:24:09.640+0900 E/rpm-installer( 5690): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
09-08 12:24:09.640+0900 E/rpm-installer( 5690): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
09-08 12:24:09.640+0900 E/rpm-installer( 5690): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
09-08 12:24:09.650+0900 E/PKGMGR_PARSER( 5690): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
09-08 12:24:09.650+0900 E/PKGMGR_PARSER( 5690): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
09-08 12:24:09.890+0900 E/PKGMGR_PARSER( 5690): pkgmgr_parser.c: __check_theme(142) > theme for installation.
09-08 12:24:09.910+0900 E/PKGMGR_CERT( 5690): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
09-08 12:24:09.910+0900 E/PKGMGR_CERT( 5690): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 121
09-08 12:24:09.910+0900 E/PKGMGR_CERT( 5690): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 121
09-08 12:24:09.910+0900 E/PKGMGR_CERT( 5690): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 40 12
09-08 12:24:09.910+0900 E/PKGMGR_CERT( 5690): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 37 14
09-08 12:24:09.910+0900 E/PKGMGR_CERT( 5690): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 38 14
09-08 12:24:09.910+0900 E/PKGMGR_CERT( 5690): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 12
09-08 12:24:09.920+0900 E/PKGMGR_CERT( 5690): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
09-08 12:24:09.920+0900 I/Tizen::App( 1250): (1894) > PackageEventHandler - req: 12500002, pkg_type: tpk, pkg_name: org.example.basicgalleryex1, key: install_percent, val: 60
09-08 12:24:09.920+0900 I/Tizen::App( 1250): (119) > InstallationInProgress [60]
09-08 12:24:09.920+0900 I/Tizen::App( 1250): (1584) > Package = [org.example.basicgalleryex1], Key = [install_percent], Value = [60], install = [1]
09-08 12:24:09.920+0900 E/PKGMGR  ( 1551): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-08 12:24:09.920+0900 E/PKGMGR  ( 1551): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-08 12:24:09.940+0900 E/rpm-installer( 5690): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
09-08 12:24:09.960+0900 E/rpm-installer( 5690): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
09-08 12:24:09.960+0900 E/PKGMGR  ( 1551): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-08 12:24:09.960+0900 I/Tizen::App( 1250): (1894) > PackageEventHandler - req: 12500002, pkg_type: tpk, pkg_name: org.example.basicgalleryex1, key: install_percent, val: 100
09-08 12:24:09.960+0900 E/PKGMGR  ( 1551): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-08 12:24:09.960+0900 I/Tizen::App( 1250): (119) > InstallationInProgress [100]
09-08 12:24:09.960+0900 I/Tizen::App( 1250): (1584) > Package = [org.example.basicgalleryex1], Key = [install_percent], Value = [100], install = [1]
09-08 12:24:10.521+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-08 12:24:10.601+0900 E/PKGMGR_SERVER( 5687): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
09-08 12:24:10.731+0900 I/APP_CORE(  842): appcore-efl.c: __do_app(514) > [APP 842] Event: MEM_FLUSH State: PAUSED
09-08 12:24:12.142+0900 E/PKGMGR  ( 1551): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-08 12:24:12.142+0900 E/PKGMGR  ( 1551): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-08 12:24:12.142+0900 I/Tizen::App( 1250): (1894) > PackageEventHandler - req: 12500002, pkg_type: tpk, pkg_name: org.example.basicgalleryex1, key: end, val: ok
09-08 12:24:12.142+0900 I/Tizen::App( 1250): (78) > Installation is Completed. [Package = org.example.basicgalleryex1]
09-08 12:24:12.142+0900 I/Tizen::App( 1250): (671) > Enter. package(org.example.basicgalleryex1), installationResult(0)
09-08 12:24:12.152+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
09-08 12:24:12.152+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
09-08 12:24:12.152+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
09-08 12:24:12.172+0900 I/Tizen::App( 1250): (1360) > package(org.example.basicgalleryex1), version(1.0.0), type(tpk), displayName(basicgalleryex1), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.basicgalleryex1), storeClient(), appRootPath(/opt/usr/apps/org.example.basicgalleryex1)
09-08 12:24:12.182+0900 E/PKGMGR_SERVER( 5687): pkgmgr-server.c: __unset_recovery_mode(282) > remove recovery_file[/opt/share/packages/.recovery/pkgmgr/org.example.basicgalleryex1-1.0.0-arm.tpk] fail
09-08 12:24:12.182+0900 E/PKGMGR_SERVER( 5687): pkgmgr-server.c: sighandler(417) > child NORMAL exit [5690]
09-08 12:24:12.182+0900 I/Tizen::App( 1250): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.basicgalleryex1]
09-08 12:24:12.182+0900 W/ISF_PANEL_EFL(  778): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
09-08 12:24:12.192+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.basicgalleryex1]
09-08 12:24:12.192+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.basicgalleryex1]
09-08 12:24:12.192+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
09-08 12:24:12.192+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
09-08 12:24:12.192+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.basicgalleryex1]
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
09-08 12:24:49.519+0900 W/CRASH_MANAGER( 5761): worker.c: worker_job(1199) > 1105770626173147330508
