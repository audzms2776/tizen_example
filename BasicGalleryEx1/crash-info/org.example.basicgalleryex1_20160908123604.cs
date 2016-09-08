S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPD4
Build-Date: 2016.04.11 14:59:15

Crash Information
Process Name: basicgalleryex1
PID: 7848
Date: 2016-09-08 12:36:04+0900
Executable File Path: /opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 7848, uid 5000)

Register Information
r0   = 0xb8771238, r1   = 0x00000000
r2   = 0xb2835c08, r3   = 0x80013ea0
r4   = 0xb87573a0, r5   = 0xb8753710
r6   = 0x80013ea0, r7   = 0xbec190d0
r8   = 0xb282d931, r9   = 0xbec190fc
r10  = 0xb87a13e8, fp   = 0xbec19284
ip   = 0x8000cc67, sp   = 0xbec190a8
lr   = 0xb8771238, pc   = 0xb282d950
cpsr = 0xa00d0030

Memory Information
MemTotal:   987012 KB
MemFree:    127492 KB
Buffers:     21024 KB
Cached:     223552 KB
VmPeak:     119504 KB
VmSize:     119500 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       26368 KB
VmRSS:       26368 KB
VmData:      36980 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35620 KB
VmPTE:          92 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 7848 TID = 7848
7848 7851 7878 7883 

Maps Information
b14b9000 b1cb8000 rw-p [stack:7883]
b1cfb000 b1d03000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1d14000 b1d15000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1d25000 b1d39000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1d4d000 b1d4e000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1d5e000 b1d61000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1d72000 b1d73000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1d83000 b1d85000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1d95000 b1d97000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1da7000 b1db7000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1dc7000 b1dd3000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1de5000 b25e4000 rw-p [stack:7878]
b27e4000 b27eb000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27fc000 b2804000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b2816000 b281c000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b282c000 b282e000 r-xp /opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1
b297e000 b2a61000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a98000 b2ac0000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2ad2000 b32d1000 rw-p [stack:7851]
b32d1000 b32d3000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32e3000 b32ed000 r-xp /lib/libnss_files-2.20-2014.11.so
b32fe000 b3307000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3318000 b3329000 r-xp /lib/libnsl-2.20-2014.11.so
b333c000 b3342000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3353000 b3354000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b337c000 b3383000 r-xp /usr/lib/libminizip.so.1.0.0
b3393000 b3398000 r-xp /usr/lib/libstorage.so.0.1
b33a8000 b3407000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b341d000 b3431000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3441000 b3485000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3495000 b349d000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34ad000 b34dd000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34f0000 b35a9000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35bd000 b3610000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3621000 b363c000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b364c000 b370d000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3720000 b3730000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3740000 b374d000 r-xp /usr/lib/libmdm-common.so.1.0.98
b375e000 b3765000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3775000 b37b6000 r-xp /usr/lib/libmdm.so.1.2.12
b37c6000 b37ce000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37dd000 b37ed000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b380e000 b386e000 r-xp /usr/lib/libasound.so.2.0.0
b3880000 b3883000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3893000 b3896000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38a6000 b38ab000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38bb000 b38bc000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38cc000 b38d7000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38eb000 b38f2000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3902000 b3908000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3918000 b391d000 r-xp /usr/lib/libmmfsession.so.0.0.1
b392d000 b3948000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3958000 b395f000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b396f000 b3972000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3983000 b39b1000 r-xp /usr/lib/libidn.so.11.5.44
b39c1000 b39d7000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39e8000 b39f2000 r-xp /usr/lib/libcares.so.2.1.0
b3a02000 b3a0c000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a1c000 b3a1e000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a2e000 b3a2f000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a3f000 b3a43000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a54000 b3a7c000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a8d000 b3ab6000 r-xp /usr/lib/libturbojpeg.so
b3ad6000 b3adc000 r-xp /usr/lib/libgif.so.4.1.6
b3aec000 b3b32000 r-xp /usr/lib/libcurl.so.4.3.0
b3b43000 b3b64000 r-xp /usr/lib/libexif.so.12.3.3
b3b7f000 b3b94000 r-xp /usr/lib/libtts.so
b3ba5000 b3bad000 r-xp /usr/lib/libfeedback.so.0.1.4
b3bbd000 b3c83000 r-xp /usr/lib/libdali-core.so.0.0.0
b3ca3000 b3d9b000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3dba000 b3e88000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e9f000 b3ea1000 r-xp /usr/lib/libboost_system.so.1.51.0
b3eb1000 b3eb7000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3ec7000 b3eea000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3efb000 b3efd000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f0d000 b3f0f000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f20000 b3f25000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f3c000 b3f3e000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f4e000 b3f55000 r-xp /usr/lib/libsensord-share.so
b3f65000 b3f7d000 r-xp /usr/lib/libsensor.so.1.1.0
b3f8e000 b3f91000 r-xp /usr/lib/libXv.so.1.0.0
b3fa1000 b3fa6000 r-xp /usr/lib/libutilX.so.1.1.0
b3fb6000 b3fbb000 r-xp /usr/lib/libappcore-common.so.1.1
b3fcb000 b3fd2000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fe5000 b3fe9000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3ffa000 b40d8000 r-xp /usr/lib/libCOREGL.so.4.0
b40f8000 b40fb000 r-xp /usr/lib/libuuid.so.1.3.0
b410b000 b4122000 r-xp /usr/lib/libblkid.so.1.1.0
b4133000 b4135000 r-xp /usr/lib/libXau.so.6.0.0
b4145000 b418c000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b419e000 b41a4000 r-xp /usr/lib/libjson-c.so.2.0.1
b41b5000 b41b9000 r-xp /usr/lib/libogg.so.0.7.1
b41c9000 b41eb000 r-xp /usr/lib/libvorbis.so.0.4.3
b41fb000 b42df000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42fb000 b42fe000 r-xp /usr/lib/libEGL.so.1.4
b430f000 b4315000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4325000 b4327000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4337000 b4344000 r-xp /usr/lib/libGLESv2.so.2.0
b4355000 b43b7000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43cc000 b43e4000 r-xp /usr/lib/libmount.so.1.1.0
b43f6000 b440a000 r-xp /usr/lib/libxcb.so.1.1.0
b441a000 b4421000 r-xp /lib/libcrypt-2.20-2014.11.so
b4459000 b445b000 r-xp /usr/lib/libiri.so
b446b000 b4476000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4487000 b44bd000 r-xp /usr/lib/libpulse.so.0.16.2
b44ce000 b4511000 r-xp /usr/lib/libsndfile.so.1.0.25
b4526000 b453b000 r-xp /lib/libexpat.so.1.5.2
b454d000 b460b000 r-xp /usr/lib/libcairo.so.2.11200.14
b461f000 b4627000 r-xp /usr/lib/libdrm.so.2.4.0
b4637000 b463a000 r-xp /usr/lib/libdri2.so.0.0.0
b464a000 b4698000 r-xp /usr/lib/libssl.so.1.0.0
b46ad000 b46b9000 r-xp /usr/lib/libeeze.so.1.13.0
b46ca000 b46d3000 r-xp /usr/lib/libethumb.so.1.13.0
b46e3000 b46e6000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46f6000 b48ad000 r-xp /usr/lib/libcrypto.so.1.0.0
b5698000 b56a1000 r-xp /usr/lib/libXi.so.6.1.0
b56b1000 b56b3000 r-xp /usr/lib/libXgesture.so.7.0.0
b56c3000 b56c7000 r-xp /usr/lib/libXtst.so.6.1.0
b56d7000 b56dd000 r-xp /usr/lib/libXrender.so.1.3.0
b56ed000 b56f3000 r-xp /usr/lib/libXrandr.so.2.2.0
b5703000 b5705000 r-xp /usr/lib/libXinerama.so.1.0.0
b5716000 b5719000 r-xp /usr/lib/libXfixes.so.3.1.0
b5729000 b5734000 r-xp /usr/lib/libXext.so.6.4.0
b5744000 b5746000 r-xp /usr/lib/libXdamage.so.1.1.0
b5756000 b5758000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5768000 b584a000 r-xp /usr/lib/libX11.so.6.3.0
b585e000 b5865000 r-xp /usr/lib/libXcursor.so.1.0.2
b5875000 b588d000 r-xp /usr/lib/libudev.so.1.6.0
b588f000 b5892000 r-xp /lib/libattr.so.1.1.0
b58a2000 b58c2000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58c3000 b58c8000 r-xp /usr/lib/libffi.so.6.0.2
b58d9000 b58f1000 r-xp /lib/libz.so.1.2.8
b5901000 b5903000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5913000 b59e8000 r-xp /usr/lib/libxml2.so.2.9.2
b59fd000 b5a98000 r-xp /usr/lib/libstdc++.so.6.0.20
b5ab4000 b5ab7000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ac7000 b5ae0000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5af1000 b5b02000 r-xp /lib/libresolv-2.20-2014.11.so
b5b16000 b5b90000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5ba5000 b5ba7000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bb7000 b5bbe000 r-xp /usr/lib/libembryo.so.1.13.0
b5bce000 b5bd8000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5be9000 b5c01000 r-xp /usr/lib/libpng12.so.0.50.0
b5c12000 b5c35000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c56000 b5c6a000 r-xp /usr/lib/libector.so.1.13.0
b5c7b000 b5c93000 r-xp /usr/lib/liblua-5.1.so
b5ca4000 b5cfb000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d0f000 b5d37000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d48000 b5d5b000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d6c000 b5da6000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5db7000 b5dc5000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5dd5000 b5ddd000 r-xp /usr/lib/libtbm.so.1.0.0
b5ded000 b5dfa000 r-xp /usr/lib/libeio.so.1.13.0
b5e0a000 b5e0c000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e1c000 b5e21000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e31000 b5e48000 r-xp /usr/lib/libefreet.so.1.13.0
b5e5a000 b5e7a000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e8a000 b5eaa000 r-xp /usr/lib/libecore_con.so.1.13.0
b5eac000 b5eb2000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ec2000 b5ed3000 r-xp /usr/lib/libemotion.so.1.13.0
b5ee4000 b5eeb000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5efb000 b5f0a000 r-xp /usr/lib/libeo.so.1.13.0
b5f1b000 b5f2d000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f3e000 b5f43000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f53000 b5f6c000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f7c000 b5f99000 r-xp /usr/lib/libeet.so.1.13.0
b5fb2000 b5ffa000 r-xp /usr/lib/libeina.so.1.13.0
b600b000 b601b000 r-xp /usr/lib/libefl.so.1.13.0
b602c000 b6111000 r-xp /usr/lib/libicuuc.so.51.1
b612e000 b626e000 r-xp /usr/lib/libicui18n.so.51.1
b6285000 b62bd000 r-xp /usr/lib/libecore_x.so.1.13.0
b62cf000 b62d2000 r-xp /lib/libcap.so.2.21
b62e2000 b630b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b631c000 b6323000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6335000 b636c000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b637d000 b6468000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b647b000 b64f4000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6506000 b650b000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b651b000 b6525000 r-xp /usr/lib/libvconf.so.0.2.45
b6535000 b6537000 r-xp /usr/lib/libvasum.so.0.3.1
b6547000 b6549000 r-xp /usr/lib/libttrace.so.1.1
b6559000 b655c000 r-xp /usr/lib/libiniparser.so.0
b656c000 b6592000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65a2000 b65a7000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65b8000 b65cf000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65e0000 b664b000 r-xp /lib/libm-2.20-2014.11.so
b665c000 b6662000 r-xp /lib/librt-2.20-2014.11.so
b6673000 b6680000 r-xp /usr/lib/libunwind.so.8.0.1
b66b6000 b67da000 r-xp /lib/libc-2.20-2014.11.so
b67ef000 b6808000 r-xp /lib/libgcc_s-4.9.so.1
b6818000 b68fa000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b690b000 b6935000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6946000 b6982000 r-xp /usr/lib/libsystemd.so.0.4.0
b6984000 b6a07000 r-xp /usr/lib/libedje.so.1.13.0
b6a1a000 b6a38000 r-xp /usr/lib/libecore.so.1.13.0
b6a58000 b6bdf000 r-xp /usr/lib/libevas.so.1.13.0
b6c14000 b6c28000 r-xp /lib/libpthread-2.20-2014.11.so
b6c3c000 b6e70000 r-xp /usr/lib/libelementary.so.1.13.0
b6e9f000 b6ea3000 r-xp /usr/lib/libsmack.so.1.0.0
b6eb3000 b6eba000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6eca000 b6ecc000 r-xp /usr/lib/libdlog.so.0.0.0
b6edc000 b6edf000 r-xp /usr/lib/libbundle.so.0.1.22
b6eef000 b6ef1000 r-xp /lib/libdl-2.20-2014.11.so
b6f02000 b6f1a000 r-xp /usr/lib/libaul.so.0.1.0
b6f2e000 b6f33000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f44000 b6f51000 r-xp /usr/lib/liblptcp.so
b6f63000 b6f67000 r-xp /usr/lib/libsys-assert.so
b6f78000 b6f98000 r-xp /lib/ld-2.20-2014.11.so
b6fa9000 b6fae000 r-xp /usr/bin/launchpad-loader
b8529000 b87d9000 rw-p [heap]
bebf9000 bec1a000 rw-p [stack]
bebf9000 bec1a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7848)
Call Stack Count: 21
 0: gengrid_it_cb + 0x1f (0xb282d950) [/opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1] + 0x1950
 1: (0xb6d2a0d5) [/usr/lib/libelementary.so.1] + 0xee0d5
 2: (0xb6d2c533) [/usr/lib/libelementary.so.1] + 0xf0533
 3: (0xb6a8d175) [/usr/lib/libevas.so.1] + 0x35175
 4: (0xb5f06219) [/usr/lib/libeo.so.1] + 0xb219
 5: eo_event_callback_call + 0x68 (0xb5f04fb9) [/usr/lib/libeo.so.1] + 0x9fb9
 6: (0xb6a8d515) [/usr/lib/libevas.so.1] + 0x35515
 7: (0xb6a8d5bf) [/usr/lib/libevas.so.1] + 0x355bf
 8: (0xb6a95de7) [/usr/lib/libevas.so.1] + 0x3dde7
 9: evas_canvas_event_feed_mouse_up + 0x6a (0xb6a9aea7) [/usr/lib/libevas.so.1] + 0x42ea7
10: evas_event_feed_mouse_up + 0x30 (0xb6a9e8e9) [/usr/lib/libevas.so.1] + 0x468e9
11: (0xb46e51cb) [/usr/lib/libecore_input_evas.so.1] + 0x21cb
12: (0xb6a25c4b) [/usr/lib/libecore.so.1] + 0xbc4b
13: (0xb6a2ba5d) [/usr/lib/libecore.so.1] + 0x11a5d
14: ecore_main_loop_begin + 0x3e (0xb6a2bc83) [/usr/lib/libecore.so.1] + 0x11c83
15: appcore_efl_main + 0x20c (0xb6f312bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
16: ui_app_main + 0xc0 (0xb3fe7909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
17: main + 0x122 (0xb282d373) [/opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1] + 0x1373
18: (0xb6faabb5) [/opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1] + 0x1bb5
19: __libc_start_main + 0x114 (0xb66cc4bc) [/lib/libc.so.6] + 0x164bc
20: (0xb6faaeb4) [/opt/usr/apps/org.example.basicgalleryex1/bin/basicgalleryex1] + 0x1eb4
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
= [basicgalleryex1], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
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
09-08 12:36:00.443+0900 W/CRASH_MANAGER( 7820): worker.c: worker_job(1199) > 11078136261731473305759
09-08 12:36:00.504+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=4238901
09-08 12:36:00.574+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=4238979
09-08 12:36:00.584+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.basicgalleryex1)
09-08 12:36:00.584+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
09-08 12:36:00.584+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 860
09-08 12:36:00.594+0900 E/RESOURCED(  671): block.c: block_prelaunch_state(134) > insert data org.example.basicgalleryex1, table num : 8
09-08 12:36:00.594+0900 E/RESOURCED(  671): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-08 12:36:00.594+0900 I/INDICATOR(  659): clock.c: indicator_clock_changed_cb(195) > ""
09-08 12:36:00.594+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
09-08 12:36:00.604+0900 W/AUL_PAD ( 1491): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
09-08 12:36:00.604+0900 W/AUL_PAD ( 1491): launchpad.c: __send_result_to_caller(267) > Check app launching
09-08 12:36:00.604+0900 E/UXT     (  659): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 12:36
09-08 12:36:00.604+0900 I/INDICATOR(  659): clock.c: getTimeFormatted(176) > "time format : 오후 12:36"
09-08 12:36:00.604+0900 I/INDICATOR(  659): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 12:36"
09-08 12:36:00.604+0900 W/INDICATOR(  659): clock.c: indicator_clock_changed_cb(272) > 
09-08 12:36:00.604+0900 I/INDICATOR(  659): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145514497 Time: <font_size=31> </font_size> <font_size=31> 오후 12:36</font_size></font>"
09-08 12:36:00.624+0900 I/CAPI_APPFW_APPLICATION( 7848): app_main.c: ui_app_main(789) > app_efl_main
09-08 12:36:00.624+0900 I/CAPI_APPFW_APPLICATION( 7848): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
09-08 12:36:00.654+0900 E/TBM     ( 7848): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
09-08 12:36:00.704+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 7848, appid: org.example.basicgalleryex1
09-08 12:36:00.704+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
09-08 12:36:00.704+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(425) > request cmd(1) result(7848)
09-08 12:36:00.704+0900 E/RESOURCED(  671): proc-main.c: proc_add_program_list(237) > not found ppi : org.example.basicgalleryex1
09-08 12:36:00.794+0900 I/APP_CORE( 7848): appcore-efl.c: __do_app(514) > [APP 7848] Event: RESET State: CREATED
09-08 12:36:00.794+0900 I/CAPI_APPFW_APPLICATION( 7848): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
09-08 12:36:00.804+0900 E/EFL     ( 7848): edje<7848> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-08 12:36:00.804+0900 E/EFL     ( 7848): By the power of Grayskull, your previous Embryo stack is now broken!
09-08 12:36:00.804+0900 E/EFL     ( 7848): edje<7848> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-08 12:36:00.804+0900 E/EFL     ( 7848): By the power of Grayskull, your previous Embryo stack is now broken!
09-08 12:36:00.804+0900 E/EFL     ( 7848): edje<7848> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-08 12:36:00.804+0900 E/EFL     ( 7848): By the power of Grayskull, your previous Embryo stack is now broken!
09-08 12:36:00.804+0900 E/EFL     ( 7848): edje<7848> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-08 12:36:00.804+0900 E/EFL     ( 7848): By the power of Grayskull, your previous Embryo stack is now broken!
09-08 12:36:00.804+0900 E/EFL     ( 7848): edje<7848> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-08 12:36:00.804+0900 E/EFL     ( 7848): By the power of Grayskull, your previous Embryo stack is now broken!
09-08 12:36:00.824+0900 W/APP_CORE( 7848): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6000002
09-08 12:36:00.834+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
09-08 12:36:00.844+0900 E/EFL     (  330): eo<330> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-08 12:36:00.844+0900 E/EFL     (  330): eo<330> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-08 12:36:00.854+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
09-08 12:36:00.864+0900 I/Tizen::System( 1250): (259) > Active app [org.exampl], current [com.samsun] 
09-08 12:36:00.864+0900 I/Tizen::Io( 1250): (729) > Entry not found
09-08 12:36:00.864+0900 I/Tizen::System( 1250): (157) > change brightness system value.
09-08 12:36:00.954+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
09-08 12:36:00.954+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-08 12:36:00.954+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
09-08 12:36:00.954+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
09-08 12:36:00.954+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
09-08 12:36:00.954+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
09-08 12:36:00.954+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7848) status(3)
09-08 12:36:00.954+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.basicgalleryex1(7848)
09-08 12:36:00.954+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 7848, appid: org.example.basicgalleryex1, status: fg
09-08 12:36:00.974+0900 I/APP_CORE( 7848): appcore-efl.c: __do_app(514) > [APP 7848] Event: RESUME State: CREATED
09-08 12:36:00.984+0900 I/APP_CORE( 7848): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
09-08 12:36:00.984+0900 I/APP_CORE( 7848): appcore-efl.c: __do_app(625) > [APP 7848] Initial Launching, call the resume_cb
09-08 12:36:00.984+0900 I/CAPI_APPFW_APPLICATION( 7848): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-08 12:36:01.324+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7848) status(0)
09-08 12:36:01.735+0900 I/Tizen::App( 1250): (499) > LaunchedApp(org.example.basicgalleryex1)
09-08 12:36:01.735+0900 I/Tizen::App( 1250): (733) > Finished invoking application event listener for org.example.basicgalleryex1, 7848.
09-08 12:36:01.735+0900 E/RESOURCED(  671): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.855
09-08 12:36:01.815+0900 E/EFL     ( 7848): ecore_x<7848> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=4240208
09-08 12:36:02.095+0900 E/EFL     ( 7848): ecore_x<7848> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=4240495
09-08 12:36:02.576+0900 E/EFL     ( 7848): ecore_x<7848> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=4240969
09-08 12:36:02.726+0900 I/UXT     ( 7904): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
09-08 12:36:02.986+0900 E/EFL     ( 7848): ecore_x<7848> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=4241389
09-08 12:36:03.456+0900 E/EFL     ( 7848): ecore_x<7848> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=4241848
09-08 12:36:03.847+0900 E/EFL     ( 7848): ecore_x<7848> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=4242212
09-08 12:36:04.287+0900 E/EFL     ( 7848): ecore_x<7848> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=4242687
09-08 12:36:04.347+0900 E/EFL     ( 7848): ecore_x<7848> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=4242742
09-08 12:36:04.497+0900 I/AUL_PAD ( 1491): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 7848 pgid = 7848
09-08 12:36:04.497+0900 I/AUL_PAD ( 1491): sigchild.h: __sigchild_action(143) > dead_pid(7848)
09-08 12:36:04.507+0900 E/EFL     (  330): eo<330> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-08 12:36:04.527+0900 I/AUL_PAD ( 1491): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-08 12:36:04.527+0900 I/AUL_PAD ( 1491): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-08 12:36:04.527+0900 E/AUL_PAD ( 1491): launchpad.c: main(698) > error reading sigchld info
09-08 12:36:04.527+0900 I/Tizen::App( 1250): (243) > App[org.example.basicgalleryex1] pid[7848] terminate event is forwarded
09-08 12:36:04.527+0900 I/Tizen::System( 1250): (256) > osp.accessorymanager.service provider is found.
09-08 12:36:04.527+0900 I/Tizen::System( 1250): (196) > Accessory Owner is removed [org.example.basicgalleryex1, 7848, ]
09-08 12:36:04.537+0900 I/Tizen::System( 1250): (256) > osp.system.service provider is found.
09-08 12:36:04.537+0900 I/Tizen::App( 1250): (506) > TerminatedApp(org.example.basicgalleryex1)
09-08 12:36:04.537+0900 I/Tizen::App( 1250): (512) > Not registered pid(7848)
09-08 12:36:04.537+0900 I/Tizen::System( 1250): (246) > Terminated app [org.example.basicgalleryex1]
09-08 12:36:04.537+0900 I/Tizen::Io( 1250): (729) > Entry not found
09-08 12:36:04.537+0900 I/ESD     (  880): esd_main.c: __esd_app_dead_handler(1773) > pid: 7848
09-08 12:36:04.537+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 7848
09-08 12:36:04.537+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 7848
09-08 12:36:04.537+0900 E/RESOURCED(  671): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.858
09-08 12:36:04.547+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
09-08 12:36:04.547+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-08 12:36:04.547+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
09-08 12:36:04.547+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
09-08 12:36:04.547+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
09-08 12:36:04.547+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
09-08 12:36:04.567+0900 I/Tizen::System( 1250): (157) > change brightness system value.
09-08 12:36:04.567+0900 I/Tizen::App( 1250): (782) > Finished invoking application event listener for org.example.basicgalleryex1, 7848.
09-08 12:36:04.598+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
09-08 12:36:04.598+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-08 12:36:04.598+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
09-08 12:36:04.598+0900 E/EFL     (  330): eo<330> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-08 12:36:04.628+0900 I/Tizen::System( 1250): (259) > Active app [com.samsun], current [org.exampl] 
09-08 12:36:04.638+0900 I/Tizen::Io( 1250): (729) > Entry not found
09-08 12:36:04.638+0900 I/Tizen::System( 1250): (157) > change brightness system value.
09-08 12:36:04.648+0900 I/TIZEN_N_SOUND_MANAGER(  900): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=8, ret=0x0
09-08 12:36:04.648+0900 E/TIZEN_N_SOUND_MANAGER(  900): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-08 12:36:04.648+0900 I/TIZEN_N_SOUND_MANAGER(  900): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=4, ret=0x0
09-08 12:36:04.648+0900 E/TIZEN_N_SOUND_MANAGER(  900): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-08 12:36:04.648+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
09-08 12:36:05.018+0900 W/ProcessCpuTracker( 1568): Skipping unknown process pid 7820
09-08 12:36:05.018+0900 W/ProcessCpuTracker( 1568): Skipping unknown process pid 7863
09-08 12:36:05.018+0900 W/ProcessCpuTracker( 1568): Skipping unknown process pid 7904
09-08 12:36:05.018+0900 W/ProcessCpuTracker( 1568): Skipping unknown process pid 7905
09-08 12:36:05.028+0900 W/ProcessCpuTracker( 1568): Skipping unknown process pid 7913
09-08 12:36:05.508+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=4243906
09-08 12:36:05.588+0900 E/INDICATOR(  659): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-08 12:36:05.588+0900 E/INDICATOR(  659): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-08 12:36:05.588+0900 E/INDICATOR(  659): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-08 12:36:05.588+0900 E/INDICATOR(  659): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-08 12:36:05.588+0900 E/INDICATOR(  659): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-08 12:36:05.588+0900 E/INDICATOR(  659): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-08 12:36:05.588+0900 E/INDICATOR(  659): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
09-08 12:36:05.588+0900 E/INDICATOR(  659): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-08 12:36:05.588+0900 E/INDICATOR(  659): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-08 12:36:05.588+0900 E/INDICATOR(  659): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-08 12:36:05.598+0900 E/INDICATOR(  659): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-08 12:36:05.598+0900 E/INDICATOR(  659): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-08 12:36:05.609+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=4244006
09-08 12:36:06.960+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=4245262
09-08 12:36:06.970+0900 E/cluster-view(  860): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
09-08 12:36:06.970+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=4245369
09-08 12:36:06.970+0900 E/cluster-view(  860): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
09-08 12:36:06.970+0900 W/cluster-home(  860): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
09-08 12:36:06.970+0900 W/cluster-home(  860): cluster-data-provider.cpp: OnMainScrollStarted(4739) >  Main Scroll Started Done
09-08 12:36:07.130+0900 W/cluster-home(  860): cluster-data-provider.cpp: OnMainScrollCompleted(4747) >  Main Scroll Completed
09-08 12:36:07.130+0900 W/cluster-home(  860): cluster-data-provider.cpp: OnMainScrollCompleted(4750) >  Main Scroll Completed Done
09-08 12:36:07.580+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=4245980
09-08 12:36:07.580+0900 E/cluster-view(  860): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86PowerOff]Key [Down]Event!! 
09-08 12:36:07.731+0900 I/AclService( 1394): AppManagerService.cpp: onScreenStateChange(1710) > Screen state change received by (ACL111OMWW)
09-08 12:36:07.731+0900 E/VOLUME  (  857): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-08 12:36:07.731+0900 E/VOLUME  (  857): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
09-08 12:36:07.741+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=4246130
09-08 12:36:07.751+0900 W/LOCKSCREEN(  842): dbus.c: _dbus_message_recv_cb(168) > [_dbus_message_recv_cb:168:W] PRE_LCD_OFF cause[powerkey] (status:3)
09-08 12:36:07.751+0900 W/LOCKSCREEN(  842): event.c: _lcd_off_cb(64) > [_lcd_off_cb:64:W] Dbus LCD off:powerkey
09-08 12:36:07.751+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30000:LCD_WILL_OFF
09-08 12:36:07.751+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:30000 event_info:0
09-08 12:36:07.751+0900 W/LOCKSCREEN(  842): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:3
09-08 12:36:07.751+0900 W/LOCKSCREEN(  842): daemon.c: _state_enter(378) > [_state_enter:378:W] HIDE => WILL RESUME
09-08 12:36:07.761+0900 W/APP_CORE(  860): appcore-efl.c: __cmsg_cb(1038) > LCD Off. Pause the topmost app
09-08 12:36:07.761+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
09-08 12:36:07.761+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-08 12:36:07.761+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
09-08 12:36:07.761+0900 E/LOCKSCREEN(  842): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-08 12:36:07.761+0900 E/LOCKSCREEN(  842): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
09-08 12:36:07.761+0900 W/INDICATOR(  659): main.c: _indicator_lock_status_cb(418) > LockState is Lock, but Lockscreen invisible state
09-08 12:36:07.761+0900 E/LOCKSCREEN(  842): util-daemon.c: _lock_state_timer_cb(62) > [_lock_state_timer_cb:62:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LAUNCHING_LOCK ##########
09-08 12:36:07.761+0900 W/LOCKSCREEN(  842): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:5
09-08 12:36:07.761+0900 W/LOCKSCREEN(  842): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => WILL PAUSE
09-08 12:36:07.771+0900 W/AUL     (  842): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
09-08 12:36:07.771+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
09-08 12:36:07.771+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 842
09-08 12:36:07.771+0900 I/AUL_AMD (  610): amd_launch.c: __check_app_control_privilege(1830) > Skip the privilege check in case of preloaded apps
09-08 12:36:07.781+0900 W/AUL_AMD (  610): amd_launch.c: start_process(638) > child process: 7921
09-08 12:36:07.781+0900 E/RESOURCED(  671): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-08 12:36:07.831+0900 W/AUL_AMD (  610): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 7921
09-08 12:36:07.831+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 7921, appid: com.samsung.weather-m-agent
09-08 12:36:07.841+0900 I/Tizen::App( 1250): (499) > LaunchedApp(com.samsung.weather-m-agent)
09-08 12:36:07.841+0900 I/Tizen::App( 1250): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 7921.
09-08 12:36:07.841+0900 E/AUL     (  610): app_sock.c: __connect_client_sock(231) > connect error: 2
09-08 12:36:07.841+0900 E/AUL     (  610): app_sock.c: __create_client_sock(197) > cannot connect the client socket: 2
09-08 12:36:07.841+0900 W/AUL     (  842): launch.c: app_request_to_launchpad(425) > request cmd(0) result(7921)
09-08 12:36:07.841+0900 E/RESOURCED(  671): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.weather-m
09-08 12:36:07.941+0900 E/AUL     (  610): app_sock.c: __connect_client_sock(231) > connect error: 2
09-08 12:36:07.941+0900 E/AUL     (  610): app_sock.c: __create_client_sock(197) > cannot connect the client socket: 2
09-08 12:36:07.971+0900 E/weather-agent( 7921): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
09-08 12:36:07.981+0900 E/weather-common( 7921): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
09-08 12:36:07.981+0900 E/weather-agent( 7921): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
09-08 12:36:07.981+0900 E/weather-agent( 7921): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.deco-app, PortID : lockscreen-message-port[0;m
09-08 12:36:07.991+0900 I/MESSAGE_PORT( 7921): message-port.c: __initialize(872) > initialize
09-08 12:36:07.991+0900 I/MESSAGE_PORT( 7921): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
09-08 12:36:08.111+0900 W/CRASH_MANAGER( 7820): worker.c: worker_job(1199) > 1107848626173147330576
