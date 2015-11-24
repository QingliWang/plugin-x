S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.2
Build-Number: Z300HDDE0BOK3
Build-Date: 2015.11.09 20:13:02

Crash Information
Process Name: iap-test
PID: 18731
Date: 2015-11-23 14:05:28+0530
Executable File Path: /opt/usr/apps/org.example.iap-test/bin/iap-test
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 18731, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x0000492b
r2   = 0x00000006, r3   = 0xb40b44c0
r4   = 0x00000002, r5   = 0xb40b4000
r6   = 0xb67b509c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0x00000002
r10  = 0x00000007, fp   = 0xbed953c0
ip   = 0x00000000, sp   = 0xbed95184
lr   = 0xb66abf18, pc   = 0xb66aab84
cpsr = 0x200e0010

Memory Information
MemTotal:   986992 KB
MemFree:    107736 KB
Buffers:     14704 KB
Cached:     348352 KB
VmPeak:     134920 KB
VmSize:     127916 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       34968 KB
VmRSS:       31912 KB
VmData:      39644 KB
VmStk:         136 KB
VmExe:          24 KB
VmLib:       41824 KB
VmPTE:         102 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 18731 TID = 18731
18731 18732 18742 18747 

Maps Information
b0d41000 b1540000 rw-p [stack:18747]
b1540000 b1541000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1551000 b1565000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b15c9000 b1dc8000 rw-p [stack:18742]
b1dc8000 b1f23000 r-xp /usr/lib/egl/libMali.so
b1f38000 b1fc1000 r-xp /usr/lib/evas/modules/engines/gl_generic/v-1.13/module.so
b1fd9000 b1fe3000 r-xp /usr/lib/evas/modules/engines/gl_x11/v-1.13/module.so
b1ff4000 b2000000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b2342000 b2349000 r-xp /usr/lib/libefl-extension.so.0.1.0
b235a000 b235e000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b2371000 b2377000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2387000 b2798000 r-xp /opt/usr/apps/org.example.iap-test/bin/iap-test
b2911000 b29f4000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a2b000 b2a53000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a65000 b3264000 rw-p [stack:18732]
b3264000 b3266000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3276000 b3280000 r-xp /lib/libnss_files-2.20-2014.11.so
b3291000 b329a000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32ab000 b32bc000 r-xp /lib/libnsl-2.20-2014.11.so
b32cf000 b32d5000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32e6000 b32e7000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b330f000 b3316000 r-xp /usr/lib/libminizip.so.1.0.0
b3326000 b332b000 r-xp /usr/lib/libstorage.so.0.1
b333b000 b33ac000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33c2000 b33d6000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33e6000 b342a000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b343a000 b3442000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3452000 b3482000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3495000 b354e000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3562000 b35c7000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35d8000 b35f3000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3603000 b36c4000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36d7000 b36e8000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36f8000 b3705000 r-xp /usr/lib/libmdm-common.so.1.0.97
b3716000 b371d000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b372d000 b376e000 r-xp /usr/lib/libmdm.so.1.2.10
b377e000 b3786000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3795000 b37a5000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37c6000 b3826000 r-xp /usr/lib/libasound.so.2.0.0
b3838000 b383b000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b384b000 b384e000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b385e000 b3863000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3873000 b3874000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3884000 b388f000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38a3000 b38ac000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38bc000 b38c4000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38d4000 b38d9000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38e9000 b3905000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3916000 b391d000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b392d000 b3931000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3941000 b396f000 r-xp /usr/lib/libidn.so.11.5.44
b397f000 b3995000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39a6000 b39b0000 r-xp /usr/lib/libcares.so.2.1.0
b39c0000 b39ca000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.29
b39da000 b39dc000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39ec000 b39ed000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39fd000 b3a01000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a12000 b3a3d000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a4d000 b3a76000 r-xp /usr/lib/libturbojpeg.so
b3a96000 b3a9c000 r-xp /usr/lib/libgif.so.4.1.6
b3aac000 b3af2000 r-xp /usr/lib/libcurl.so.4.3.0
b3b03000 b3b24000 r-xp /usr/lib/libexif.so.12.3.3
b3b3f000 b3b54000 r-xp /usr/lib/libtts.so
b3b65000 b3b6d000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b7e000 b3c43000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c64000 b3d5b000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d7b000 b3e49000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e60000 b3e62000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e72000 b3e78000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e88000 b3eab000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3ebc000 b3ebe000 r-xp /usr/lib/libappsvc.so.0.1.0
b3ece000 b3ed0000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3ee1000 b3ee6000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3efd000 b3eff000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f0f000 b3f16000 r-xp /usr/lib/libsensord-share.so
b3f26000 b3f3e000 r-xp /usr/lib/libsensor.so.1.1.0
b3f4f000 b3f52000 r-xp /usr/lib/libXv.so.1.0.0
b3f62000 b3f67000 r-xp /usr/lib/libutilX.so.1.1.0
b3f77000 b3f7d000 r-xp /usr/lib/libappcore-common.so.1.1
b3f8d000 b3f94000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fa7000 b3fab000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fbc000 b409a000 r-xp /usr/lib/libCOREGL.so.4.0
b40ba000 b40bd000 r-xp /usr/lib/libuuid.so.1.3.0
b40cd000 b40e4000 r-xp /usr/lib/libblkid.so.1.1.0
b40f5000 b40f7000 r-xp /usr/lib/libXau.so.6.0.0
b4107000 b414e000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4160000 b4166000 r-xp /usr/lib/libjson-c.so.2.0.1
b4177000 b417b000 r-xp /usr/lib/libogg.so.0.7.1
b418b000 b41ad000 r-xp /usr/lib/libvorbis.so.0.4.3
b41bd000 b42a1000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42bd000 b42c0000 r-xp /usr/lib/libEGL.so.1.4
b42d1000 b42d7000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42e7000 b42e9000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42f9000 b4306000 r-xp /usr/lib/libGLESv2.so.2.0
b4317000 b4379000 r-xp /usr/lib/libpixman-1.so.0.28.2
b438e000 b43a6000 r-xp /usr/lib/libmount.so.1.1.0
b43b8000 b43cc000 r-xp /usr/lib/libxcb.so.1.1.0
b43dc000 b43e3000 r-xp /lib/libcrypt-2.20-2014.11.so
b441b000 b441d000 r-xp /usr/lib/libiri.so
b442d000 b4438000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4449000 b447f000 r-xp /usr/lib/libpulse.so.0.16.2
b4490000 b44d3000 r-xp /usr/lib/libsndfile.so.1.0.25
b44e8000 b44fd000 r-xp /lib/libexpat.so.1.5.2
b450f000 b45cd000 r-xp /usr/lib/libcairo.so.2.11200.14
b45e1000 b45e9000 r-xp /usr/lib/libdrm.so.2.4.0
b45f9000 b45fc000 r-xp /usr/lib/libdri2.so.0.0.0
b460c000 b465a000 r-xp /usr/lib/libssl.so.1.0.0
b466f000 b467b000 r-xp /usr/lib/libeeze.so.1.13.0
b468c000 b4695000 r-xp /usr/lib/libethumb.so.1.13.0
b46a5000 b46a8000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46b8000 b486f000 r-xp /usr/lib/libcrypto.so.1.0.0
b565a000 b5663000 r-xp /usr/lib/libXi.so.6.1.0
b5673000 b5675000 r-xp /usr/lib/libXgesture.so.7.0.0
b5685000 b5689000 r-xp /usr/lib/libXtst.so.6.1.0
b5699000 b569f000 r-xp /usr/lib/libXrender.so.1.3.0
b56af000 b56b5000 r-xp /usr/lib/libXrandr.so.2.2.0
b56c5000 b56c7000 r-xp /usr/lib/libXinerama.so.1.0.0
b56d8000 b56db000 r-xp /usr/lib/libXfixes.so.3.1.0
b56eb000 b56f6000 r-xp /usr/lib/libXext.so.6.4.0
b5706000 b5708000 r-xp /usr/lib/libXdamage.so.1.1.0
b5718000 b571a000 r-xp /usr/lib/libXcomposite.so.1.0.0
b572a000 b580c000 r-xp /usr/lib/libX11.so.6.3.0
b5820000 b5827000 r-xp /usr/lib/libXcursor.so.1.0.2
b5837000 b584f000 r-xp /usr/lib/libudev.so.1.6.0
b5851000 b5854000 r-xp /lib/libattr.so.1.1.0
b5864000 b5884000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5885000 b588a000 r-xp /usr/lib/libffi.so.6.0.2
b589b000 b58b3000 r-xp /lib/libz.so.1.2.8
b58c3000 b58c5000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58d5000 b59aa000 r-xp /usr/lib/libxml2.so.2.9.2
b59bf000 b5a5a000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a76000 b5a79000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a89000 b5aa8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ab8000 b5ac9000 r-xp /lib/libresolv-2.20-2014.11.so
b5add000 b5b57000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b6c000 b5b6e000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b7e000 b5b85000 r-xp /usr/lib/libembryo.so.1.13.0
b5b95000 b5b9f000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5bb0000 b5bc8000 r-xp /usr/lib/libpng12.so.0.50.0
b5bd9000 b5bfc000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c1d000 b5c31000 r-xp /usr/lib/libector.so.1.13.0
b5c42000 b5c5a000 r-xp /usr/lib/liblua-5.1.so
b5c6b000 b5cc2000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cd6000 b5cfe000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d0f000 b5d22000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d33000 b5d6d000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d7e000 b5d8c000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d9c000 b5da4000 r-xp /usr/lib/libtbm.so.1.0.0
b5db4000 b5dc1000 r-xp /usr/lib/libeio.so.1.13.0
b5dd1000 b5dd3000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5de3000 b5de8000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5df8000 b5e0f000 r-xp /usr/lib/libefreet.so.1.13.0
b5e21000 b5e41000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e51000 b5e71000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e73000 b5e79000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e89000 b5e9a000 r-xp /usr/lib/libemotion.so.1.13.0
b5eab000 b5eb2000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ec2000 b5ed1000 r-xp /usr/lib/libeo.so.1.13.0
b5ee2000 b5ef4000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f05000 b5f0a000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f1a000 b5f33000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f43000 b5f60000 r-xp /usr/lib/libeet.so.1.13.0
b5f79000 b5fc1000 r-xp /usr/lib/libeina.so.1.13.0
b5fd2000 b5fe2000 r-xp /usr/lib/libefl.so.1.13.0
b5ff3000 b60d8000 r-xp /usr/lib/libicuuc.so.51.1
b60f5000 b6235000 r-xp /usr/lib/libicui18n.so.51.1
b624c000 b6284000 r-xp /usr/lib/libecore_x.so.1.13.0
b6296000 b6299000 r-xp /lib/libcap.so.2.21
b62a9000 b62d2000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62e3000 b62ea000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62fc000 b6333000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6344000 b642f000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6442000 b64bb000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64cd000 b64d2000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64e2000 b64ed000 r-xp /usr/lib/libvconf.so.0.2.45
b64fd000 b64ff000 r-xp /usr/lib/libvasum.so.0.3.1
b650f000 b6511000 r-xp /usr/lib/libttrace.so.1.1
b6521000 b6524000 r-xp /usr/lib/libiniparser.so.0
b6534000 b655a000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b656b000 b6570000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6581000 b6598000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65a9000 b6614000 r-xp /lib/libm-2.20-2014.11.so
b6625000 b662b000 r-xp /lib/librt-2.20-2014.11.so
b663c000 b6649000 r-xp /usr/lib/libunwind.so.8.0.1
b667f000 b67a3000 r-xp /lib/libc-2.20-2014.11.so
b67b8000 b67d1000 r-xp /lib/libgcc_s-4.9.so.1
b67e1000 b68c3000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68d4000 b68fe000 r-xp /usr/lib/libdbus-1.so.3.8.12
b690f000 b694b000 r-xp /usr/lib/libsystemd.so.0.4.0
b694d000 b69d0000 r-xp /usr/lib/libedje.so.1.13.0
b69e3000 b6a01000 r-xp /usr/lib/libecore.so.1.13.0
b6a21000 b6ba9000 r-xp /usr/lib/libevas.so.1.13.0
b6bde000 b6bf2000 r-xp /lib/libpthread-2.20-2014.11.so
b6c06000 b6e3a000 r-xp /usr/lib/libelementary.so.1.13.0
b6e69000 b6e6d000 r-xp /usr/lib/libsmack.so.1.0.0
b6e7d000 b6e84000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e94000 b6e96000 r-xp /usr/lib/libdlog.so.0.0.0
b6ea6000 b6ea9000 r-xp /usr/lib/libbundle.so.0.1.22
b6eb9000 b6ebb000 r-xp /lib/libdl-2.20-2014.11.so
b6ecc000 b6ee5000 r-xp /usr/lib/libaul.so.0.1.0
b6ef8000 b6efe000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f10000 b6f1d000 r-xp /usr/lib/liblptcp.so
b6f2f000 b6f33000 r-xp /usr/lib/libsys-assert.so
b6f44000 b6f64000 r-xp /lib/ld-2.20-2014.11.so
b6f75000 b6f7b000 r-xp /usr/bin/launchpad-loader
b7941000 b7dd7000 rw-p [heap]
bed75000 bed96000 rw-p [stack]
b7941000 b7dd7000 rw-p [heap]
bed75000 bed96000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18731)
Call Stack Count: 15
 0: gsignal + 0x34 (0xb66aab84) [/lib/libc.so.6] + 0x2bb84
 1: abort + 0x12c (0xb66abf18) [/lib/libc.so.6] + 0x2cf18
 2: (0xb66e646c) [/lib/libc.so.6] + 0x6746c
 3: (0xb66ec0d4) [/lib/libc.so.6] + 0x6d0d4
 4: (0xb66eca5c) [/lib/libc.so.6] + 0x6da5c
 5: AppDelegate::~AppDelegate() + 0x14 (0xb23b9651) [/opt/usr/apps/org.example.iap-test/bin/iap-test] + 0x32651
 6: cocos2d::app_terminate(void*) + 0x2a (0xb2428dcb) [/opt/usr/apps/org.example.iap-test/bin/iap-test] + 0xa1dcb
 7: (0xb3fa9589) [/usr/lib/libcapi-appfw-application.so.0] + 0x2589
 8: appcore_efl_main + 0x43a (0xb6efbd3f) [/usr/lib/libappcore-efl.so.1] + 0x3d3f
 9: ui_app_main + 0xc0 (0xb3fa9909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
10: cocos2d::Application::run() + 0x60 (0xb2428e45) [/opt/usr/apps/org.example.iap-test/bin/iap-test] + 0xa1e45
11: main + 0x32 (0xb23bbe23) [/opt/usr/apps/org.example.iap-test/bin/iap-test] + 0x34e23
12: (0xb6f76ccf) [/opt/usr/apps/org.example.iap-test/bin/iap-test] + 0x1ccf
13: __libc_start_main + 0x114 (0xb66954bc) [/lib/libc.so.6] + 0x164bc
14: (0xb6f77114) [/opt/usr/apps/org.example.iap-test/bin/iap-test] + 0x2114
End of Call Stack

Package Information
Package Name: org.example.iap-test
Package ID : org.example.iap-test
Version: 1.0.0
Package Type: tpk
App Name: iap-test
App ID: org.example.iap-test
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
.733+0530 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
11-23 14:05:26.743+0530 D/TASK_MGR_LITE(18604): recent_app_viewer.c: create_recent_app_item(1051) > add app: Sample 1way
11-23 14:05:26.753+0530 D/TASK_MGR_LITE(18604): recent_app_viewer.c: create_recent_app_viewer(1560) > create capture bak
11-23 14:05:26.763+0530 D/LAUNCH  (18604): appcore-efl.c: __before_loop(1162) > [task-mgr:Application:create:done]
11-23 14:05:26.763+0530 D/APP_CORE(18604): appcore-efl.c: __check_wm_rotation_support(841) > Disable window manager rotation
11-23 14:05:26.763+0530 D/APP_CORE(18604): appcore.c: __aul_handler(581) > [APP 18604]     AUL event: AUL_START
11-23 14:05:26.763+0530 I/APP_CORE(18604): appcore-efl.c: __do_app(514) > [APP 18604] Event: RESET State: CREATED
11-23 14:05:26.763+0530 D/APP_CORE(18604): appcore-efl.c: __do_app(545) > [APP 18604] RESET
11-23 14:05:26.763+0530 D/LAUNCH  (18604): appcore-efl.c: __do_app(547) > [task-mgr:Application:reset:start]
11-23 14:05:26.763+0530 D/APP_CORE(18604): appcore-efl.c: __do_app(550) > [__SUSPEND__] reset case
11-23 14:05:26.763+0530 D/APP_CORE(18604): appcore-efl.c: __appcore_efl_exit_from_suspend(379) > [__SUSPEND__]
11-23 14:05:26.763+0530 I/CAPI_APPFW_APPLICATION(18604): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
11-23 14:05:26.763+0530 D/LAUNCH  (18604): appcore-efl.c: __do_app(560) > [task-mgr:Application:reset:done]
11-23 14:05:26.763+0530 D/APP_CORE(18604): appcore.c: __aul_handler(602) > [SECURE_LOG] caller_appid : (null)
11-23 14:05:26.763+0530 E/EFL     (18604): edje<18604> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
11-23 14:05:26.763+0530 E/EFL     (18604): By the power of Grayskull, your previous Embryo stack is now broken!
11-23 14:05:26.763+0530 E/EFL     (18604): edje<18604> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
11-23 14:05:26.763+0530 E/EFL     (18604): By the power of Grayskull, your previous Embryo stack is now broken!
11-23 14:05:26.773+0530 W/APP_CORE(18604): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:7200003
11-23 14:05:26.773+0530 D/APP_CORE(18604): appcore-efl.c: __add_win(759) > [EVENT_TEST][EVENT] __add_win WIN:7200003
11-23 14:05:26.773+0530 D/APP_CORE(18604): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
11-23 14:05:26.773+0530 D/AUL     (18604): app_sock.c: __app_send_raw(288) > pid(-2) : cmd(35)
11-23 14:05:26.773+0530 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 35
11-23 14:05:26.953+0530 E/EFL     ( 2084): ecore_x<2084> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=93145411
11-23 14:05:26.953+0530 D/STARTER ( 2004): hw_key.c: _key_release_cb(552) > [_key_release_cb:552] _key_release_cb : XF86Home Released
11-23 14:05:26.953+0530 W/STARTER ( 2004): hw_key.c: _key_release_cb(580) > [_key_release_cb:580] Home Key is released
11-23 14:05:26.953+0530 E/EFL     ( 2084): evas_events.c: _evas_canvas_event_feed_key_up_with_keycode(3010) > [SECURE_LOG] Evas KeyEvent:release time=93145411 keyname = XF86Home key = XF86Home keycode = 147
11-23 14:05:26.953+0530 D/STARTER ( 2004): lock-daemon-lite.c: lockd_get_hall_status(360) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.53/src/lock-daemon-lite.c:360:D] [ == lockd_get_hall_status == ]
11-23 14:05:26.953+0530 E/STARTER ( 2004): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(340) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.53/src/lock-daemon-lite.c:340:E] dbus_connection_send error(No reply)
11-23 14:05:26.953+0530 E/STARTER ( 2004): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(344) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.53/src/lock-daemon-lite.c:344:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
11-23 14:05:26.953+0530 E/STARTER ( 2004): )
11-23 14:05:26.953+0530 D/STARTER ( 2004): hw_key.c: _key_release_cb(618) > [_key_release_cb:618] delete cancelkey timer
11-23 14:05:26.953+0530 I/SYSPOPUP( 2093): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
11-23 14:05:26.953+0530 D/TASK_MGR_LITE(18604): recent_app_viewer.c: on_scroll_to_cb(1169) > on_scroll_to_cb
11-23 14:05:26.953+0530 D/TASK_MGR_LITE(18604): recent_app_viewer.c: on_scroll_to_cb(1185) > v_page: 146
11-23 14:05:26.953+0530 D/TASK_MGR_LITE(18604): recent_app_viewer.c: on_scroller_move(999) > on_scroller_move
11-23 14:05:26.953+0530 D/TASK_MGR_LITE(18604): recent_app_viewer.c: update_capture_animation(382) > update_capture_animation
11-23 14:05:26.953+0530 D/TASK_MGR_LITE(18604): recent_app_viewer.c: find_capture_app(184) > v_page: 146
11-23 14:05:26.953+0530 D/TASK_MGR_LITE(18604): recent_app_viewer.c: find_capture_app(191) > capture app index: 0
11-23 14:05:26.963+0530 E/EFL     (18731): ecore_x<18731> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=93145411
11-23 14:05:26.963+0530 E/EFL     (18731): evas_events.c: _evas_canvas_event_feed_key_up_with_keycode(3010) > [SECURE_LOG] Evas KeyEvent:release time=93145411 keyname = XF86Home key = XF86Home keycode = 147
11-23 14:05:26.963+0530 I/SYSPOPUP( 2093): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
11-23 14:05:26.963+0530 D/VOLUME  ( 2093): volume_control.c: volume_control_close(828) > [volume_control_close:828] Start closing volume
11-23 14:05:26.963+0530 E/VOLUME  ( 2093): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
11-23 14:05:26.963+0530 E/VOLUME  ( 2093): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
11-23 14:05:26.963+0530 D/UXT     (  351): uxt_theme.c: uxt_theme_delete_color_table(654) > color table (b88fb090) is freed
11-23 14:05:26.963+0530 D/VOLUME  ( 2093): volume_key_event.c: volume_key_event_key_ungrab(179) > [volume_key_event_key_ungrab:179] key ungrabed
11-23 14:05:26.963+0530 D/VOLUME  ( 2093): volume_control.c: volume_control_close(853) > [volume_control_close:853] ungrab key : 1/1
11-23 14:05:26.963+0530 D/VOLUME  ( 2093): volume_key_event.c: volume_key_event_key_grab(128) > [volume_key_event_key_grab:128] count_grabed : 1
11-23 14:05:26.963+0530 D/VOLUME  ( 2093): volume_control.c: volume_control_close(875) > [volume_control_close:875] End closing volume
11-23 14:05:26.973+0530 W/AUL_AMD (  608): amd_launch.c: __e17_status_handler(3328) > pid(18604) status(0)
11-23 14:05:26.973+0530 D/AUL_AMD (  608): amd_launch.c: __send_cpu_boost(538) > __send_cpu_boost enter
11-23 14:05:26.973+0530 D/AUL_AMD (  608): amd_launch.c: __send_cpu_boost(563) > __send_cpu_boost ok
11-23 14:05:26.973+0530 D/LAUNCH  (  608): amd_launch.c: __e17_status_handler(3384) > [task-mgr:Application:Launching:done]
11-23 14:05:26.973+0530 W/AUL_AMD (  608): amd_launch.c: __e17_status_handler(3328) > pid(18604) status(0)
11-23 14:05:26.973+0530 D/AUL_AMD (  608): amd_launch.c: __send_cpu_boost(538) > __send_cpu_boost enter
11-23 14:05:26.973+0530 D/AUL_AMD (  608): amd_launch.c: __send_cpu_boost(563) > __send_cpu_boost ok
11-23 14:05:26.973+0530 D/LAUNCH  (  608): amd_launch.c: __e17_status_handler(3384) > [task-mgr:Application:Launching:done]
11-23 14:05:26.973+0530 W/AUL_AMD (  608): amd_launch.c: __e17_status_handler(3328) > pid(18731) status(4)
11-23 14:05:26.973+0530 D/QUICKPANEL( 2094): QuickpanelApp.cpp: __onEcoreEventMsgReceived(925) > [0;34m>>>HIT<<<[0;m
11-23 14:05:26.973+0530 D/AUL_AMD (  608): amd_status.c: _status_update_app_info_list(431) > pid(18731) status(4)
11-23 14:05:26.973+0530 D/AUL_AMD (  608): amd_status.c: _status_update_app_info_list(442) > pid(18731) appid(org.example.iap-test) pkgid(org.example.iap-test) status(4)
11-23 14:05:26.973+0530 W/AUL     (  608): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.iap-test(18731)
11-23 14:05:26.973+0530 W/AUL     (  608): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 18731, appid: org.example.iap-test, status: bg
11-23 14:05:26.983+0530 D/QUICKPANEL( 2094): QuickpanelApp.cpp: __onEcoreEventMsgReceived(925) > [0;34m>>>HIT<<<[0;m
11-23 14:05:26.983+0530 W/AUL_AMD (  608): amd_launch.c: __e17_status_handler(3328) > pid(18604) status(3)
11-23 14:05:26.983+0530 D/AUL_AMD (  608): amd_key.c: _key_ungrab(265) > _key_ungrab, win : e00002
11-23 14:05:26.983+0530 I/samsung-log-manager( 1449): SLogMgr_UseAppStatusMonitor.cpp: DbusSignalHandlerAppFw(233) > [SECURE_LOG] [(233)]: Background 18731 org.example.iap-test
11-23 14:05:26.983+0530 I/samsung-log-manager( 1449): SLogMgr_NativeDbHelper.cpp: ExecQuery(180) > [SECURE_LOG] [(180)]: query tmp [INSERT INTO use_app_survey(app_id,duration,timestamp,time_zone) VALUES ('org.example.iap-test',32460,1448267726987,'Asia/Kolkata');]
11-23 14:05:26.983+0530 W/AUL_AMD (  608): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
11-23 14:05:26.983+0530 W/AUL_AMD (  608): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
11-23 14:05:26.983+0530 D/AUL_AMD (  608): amd_launch.c: __send_cpu_boost(538) > __send_cpu_boost enter
11-23 14:05:26.983+0530 D/AUL_AMD (  608): amd_launch.c: __send_cpu_boost(563) > __send_cpu_boost ok
11-23 14:05:26.983+0530 D/AUL_AMD (  608): amd_status.c: _status_update_app_info_list(431) > pid(18604) status(3)
11-23 14:05:26.983+0530 D/AUL_AMD (  608): amd_status.c: _status_update_app_info_list(442) > pid(18604) appid(com.samsung.task-mgr) pkgid(com.samsung.task-mgr) status(3)
11-23 14:05:26.983+0530 W/AUL     (  608): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(18604)
11-23 14:05:26.983+0530 W/AUL     (  608): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 18604, appid: com.samsung.task-mgr, status: fg
11-23 14:05:26.983+0530 D/RESOURCED(  667): heart-cpu.c: heart_cpu_write_data(168) > heart_cpu_write_data : pid = 18731, appname = org.example.iap-test, pkgname = org.example.iap-test, type=2
11-23 14:05:26.983+0530 D/RESOURCED(  667): cgroup.c: cgroup_read_node(153) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/net_cls/org.example.iap-test/net_cls.classid, value 306
11-23 14:05:26.983+0530 D/RESOURCED(  667): cpu.c: cpu_background_state(275) > cpu_background_state : pid = 18731, appname = org.example.iap-test
11-23 14:05:26.983+0530 D/RESOURCED(  667): cgroup.c: cgroup_write_node(133) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 18731
11-23 14:05:26.983+0530 D/RESOURCED(  667): proc-process.c: proc_backgrd_manage(191) > BACKGRD : process 18718 set score 360 (before 330)
11-23 14:05:26.983+0530 D/RESOURCED(  667): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1693) > pid: 18731, proc_name: org.example.iap-test, cg_name: previous, oom_score_adj: 300
11-23 14:05:26.983+0530 D/RESOURCED(  667): cgroup.c: cgroup_write_node(133) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 18731
11-23 14:05:26.993+0530 D/APP_CORE(18731): appcore-efl.c: __update_win(805) > [EVENT_TEST][EVENT] __update_win WIN:2000003 fully_obscured 1
11-23 14:05:26.993+0530 D/APP_CORE(18731): appcore-efl.c: __visibility_cb(980) > bvisibility 0, b_active 1
11-23 14:05:26.993+0530 D/APP_CORE(18731): appcore-efl.c: __visibility_cb(995) >  Go to Pasue state 
11-23 14:05:26.993+0530 I/APP_CORE(18731): appcore-efl.c: __do_app(514) > [APP 18731] Event: PAUSE State: RUNNING
11-23 14:05:26.993+0530 D/APP_CORE(18731): appcore-efl.c: __do_app(581) > [APP 18731] PAUSE
11-23 14:05:26.993+0530 I/CAPI_APPFW_APPLICATION(18731): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
11-23 14:05:26.993+0530 D/APP_CORE(18731): appcore-efl.c: __trm_app_info_send_socket(241) > __trm_app_info_send_socket
11-23 14:05:26.993+0530 D/APP_CORE(18731): appcore-efl.c: __trm_app_info_send_socket(268) > send
11-23 14:05:26.993+0530 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
11-23 14:05:26.993+0530 D/PKGMGR_INFO( 1449): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_add_string(3467) > [SECURE_LOG] First value is 'http://tizen.org/category/lockapp'
11-23 14:05:27.003+0530 D/PKGMGR_INFO( 1449): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3547) > [SECURE_LOG] where = package_app_app_category.category IN ('http://tizen.org/category/lockapp') and package_app_info.app_id='com.samsung.task-mgr' and package_app_info.app_disable IN ('false','False')
11-23 14:05:27.003+0530 D/PKGMGR_INFO( 1449): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3553) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='en-gb' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_app_category.category IN ('http://tizen.org/category/lockapp') and package_app_info.app_id='com.samsung.task-mgr' and package_app_info.app_disable IN ('false','False')
11-23 14:05:27.003+0530 I/TIZEN_N_EFL_UTIL_WINDOW(18731): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 16
11-23 14:05:27.003+0530 E/APP_CORE(18731): appcore-efl.c: _capture_and_make_file(1619) > win[2000003] widget[720] height[1280]
11-23 14:05:27.003+0530 D/AUL     (18731): app_sock.c: __app_send_raw(288) > pid(-2) : cmd(33)
11-23 14:05:27.003+0530 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 33
11-23 14:05:27.003+0530 D/AUL     (18731): pkginfo.c: aul_app_get_appid_bypid(238) > [SECURE_LOG] appid for 18731 is org.example.iap-test
11-23 14:05:27.013+0530 D/PKGMGR_INFO( 1449): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_add_string(3467) > [SECURE_LOG] First value is 'http://tizen.org/category/homeapp'
11-23 14:05:27.013+0530 D/APP_CORE(18604): appcore.c: __prt_ltime(235) > [APP 18604] first idle after reset: 671 msec
11-23 14:05:27.013+0530 D/PKGMGR_INFO( 1449): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3547) > [SECURE_LOG] where = package_app_app_category.category IN ('http://tizen.org/category/homeapp') and package_app_info.app_id='com.samsung.task-mgr' and package_app_info.app_disable IN ('false','False')
11-23 14:05:27.013+0530 D/PKGMGR_INFO( 1449): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3553) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='en-gb' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_app_category.category IN ('http://tizen.org/category/homeapp') and package_app_info.app_id='com.samsung.task-mgr' and package_app_info.app_disable IN ('false','False')
11-23 14:05:27.013+0530 D/APP_CORE(18604): appcore-efl.c: __update_win(805) > [EVENT_TEST][EVENT] __update_win WIN:7200003 fully_obscured 0
11-23 14:05:27.013+0530 D/APP_CORE(18604): appcore-efl.c: __visibility_cb(980) > bvisibility 1, b_active -1
11-23 14:05:27.013+0530 D/APP_CORE(18604): appcore-efl.c: __visibility_cb(983) >  Go to Resume state
11-23 14:05:27.013+0530 I/APP_CORE(18604): appcore-efl.c: __do_app(514) > [APP 18604] Event: RESUME State: CREATED
11-23 14:05:27.013+0530 D/LAUNCH  (18604): appcore-efl.c: __do_app(610) > [task-mgr:Application:resume:start]
11-23 14:05:27.013+0530 D/APP_CORE(18604): appcore-efl.c: __do_app(613) > [__SUSPEND__] resume case
11-23 14:05:27.013+0530 D/APP_CORE(18604): appcore-efl.c: __appcore_efl_exit_from_suspend(379) > [__SUSPEND__]
11-23 14:05:27.013+0530 D/APP_CORE(18604): appcore-efl.c: __do_app(618) > [APP 18604] RESUME
11-23 14:05:27.023+0530 I/samsung-log-manager( 1449): SLogMgr_UseAppStatusMonitor.cpp: DbusSignalHandlerAppFw(218) > [SECURE_LOG] [(218)]: Foreground 18604 com.samsung.task-mgr
11-23 14:05:27.033+0530 I/APP_CORE(18604): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
11-23 14:05:27.033+0530 I/APP_CORE(18604): appcore-efl.c: __do_app(625) > [APP 18604] Initial Launching, call the resume_cb
11-23 14:05:27.033+0530 I/CAPI_APPFW_APPLICATION(18604): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
11-23 14:05:27.033+0530 D/LAUNCH  (18604): appcore-efl.c: __do_app(647) > [task-mgr:Application:resume:done]
11-23 14:05:27.033+0530 D/APP_CORE(18604): appcore-efl.c: __trm_app_info_send_socket(241) > __trm_app_info_send_socket
11-23 14:05:27.033+0530 D/APP_CORE(18604): appcore-efl.c: __trm_app_info_send_socket(268) > send
11-23 14:05:27.073+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-23 14:05:27.073+0530 D/RESOURCED(  667): proc-main.c: resourced_proc_status_change(877) > [SECURE_LOG] set foreground : 18604
11-23 14:05:27.073+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-23 14:05:27.073+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-23 14:05:27.073+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-23 14:05:27.073+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-23 14:05:27.073+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-23 14:05:27.073+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-23 14:05:27.073+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-23 14:05:27.173+0530 D/TASK_MGR_LITE(18604): capture_inotify.c: on_fd_inotify_cb(19) > on_fd_inotify_cb
11-23 14:05:27.173+0530 D/TASK_MGR_LITE(18604): capture_inotify.c: on_fd_inotify_cb(87) > A jpeg file (org.example.iap-test.jpg) is added or modified now
11-23 14:05:27.173+0530 D/TASK_MGR_LITE(18604): recent_app_viewer.c: update_app_capture(1640) > update capture file: /opt/usr/share/app_capture/org.example.iap-test.jpg
11-23 14:05:27.474+0530 D/AUL_PAD ( 1390): launchpad.c: __send_launchpad_loader(439) > Prepare another candidate process
11-23 14:05:27.484+0530 D/AUL_PAD (18761): sigchild.h: __signal_unblock_sigchld(225) > SIGCHLD unblocked
11-23 14:05:27.504+0530 D/AUL_PAD ( 1390): sigchild.h: __send_app_launch_signal(132) > send launch signal done
11-23 14:05:27.504+0530 D/PKGMGR_INFO( 1185): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3662) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/com.samsung.task-mgr/bin/task-mgr' and package_app_info.app_disable IN ('false','False')
11-23 14:05:27.504+0530 D/PKGMGR_INFO( 1185): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3668) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-gb') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/com.samsung.task-mgr/bin/task-mgr' and package_app_info.app_disable IN ('false','False')
11-23 14:05:27.514+0530 I/tizenstore(18718): iap_update_engine.c: EngineEcoreIdlerCb(253) > Delay CHECK CACHE SPACE
11-23 14:05:27.514+0530 D/AUL     ( 1185): pkginfo.c: aul_app_get_appid_bypid(238) > [SECURE_LOG] appid for 18604 is com.samsung.task-mgr
11-23 14:05:27.514+0530 I/Tizen::App( 1185): (499) > LaunchedApp(com.samsung.task-mgr)
11-23 14:05:27.514+0530 I/Tizen::App( 1185): (733) > Finished invoking application event listener for com.samsung.task-mgr, 18604.
11-23 14:05:27.524+0530 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1815
11-23 14:05:27.644+0530 D/AUL_PAD (18761): launchpad_loader.c: main(584) > [candidate] Another candidate process was forked.
11-23 14:05:27.644+0530 D/AUL_PAD (18761): preload.h: __preload_init(52) > max_cmdline_size = 1053
11-23 14:05:27.664+0530 D/AUL_PAD (18761): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b8c87d00
11-23 14:05:27.664+0530 D/AUL_PAD (18761): preload.h: __preload_init(69) > get pre-initialization function
11-23 14:05:27.664+0530 D/AUL_PAD (18761): preload.h: __preload_init(73) > get shutdown function
11-23 14:05:27.674+0530 D/AUL_PAD (18761): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b8c7d3f0
11-23 14:05:27.684+0530 D/AUL_PAD (18761): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b8c7f640
11-23 14:05:27.684+0530 D/AUL_PAD (18761): preload.h: __preload_init(69) > get pre-initialization function
11-23 14:05:27.684+0530 D/AUL_PAD (18761): preload.h: __preload_init(73) > get shutdown function
11-23 14:05:27.694+0530 D/AUL_PAD (18761): process_pool_preload.h: __preload_init_for_process_pool(100) > preload /usr/lib/libboost_thread.so.1.51.0 - handle : b8c807f0
11-23 14:05:27.864+0530 D/AUL_PAD (18761): process_pool_preload.h: __preload_init_for_process_pool(100) > preload /usr/lib/libdali-toolkit.so - handle : b8c815f8
11-23 14:05:27.864+0530 D/AUL_PAD (18761): process_pool_preload.h: __preload_init_for_process_pool(100) > preload /usr/lib/libcairo.so - handle : b4632000
11-23 14:05:27.874+0530 D/AUL_PAD (18761): process_pool_preload.h: __preload_init_for_process_pool(100) > preload /usr/lib/libefl-assist.so.0 - handle : b8c942c8
11-23 14:05:27.924+0530 D/AUL_PAD (18761): process_pool_preload.h: __preload_init_for_process_pool(100) > preload /usr/lib/libprotobuf.so - handle : b8c94960
11-23 14:05:27.954+0530 D/AUL_PAD (18761): process_pool_preload.h: __preload_init_for_process_pool(100) > preload /usr/lib/libcapi-media-player.so.0 - handle : b8c96150
11-23 14:05:27.984+0530 D/AUL_PAD (18761): process_pool_preload.h: __preload_init_for_process_pool(100) > preload /usr/lib/libcapi-media-camera.so.0 - handle : b8c98d48
11-23 14:05:27.984+0530 D/AUL_PAD (18761): preexec.h: __preexec_init(76) > preexec start
11-23 14:05:27.984+0530 D/AUL_PAD (18761): preexec.h: __preexec_init(106) > preexec tpk /usr/lib/libosp-env-config.so# - handle : b8c95d80
11-23 14:05:27.984+0530 D/AUL     (18761): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 2
11-23 14:05:27.984+0530 D/AUL     (18761): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type2
11-23 14:05:27.984+0530 D/AUL_PAD ( 1390): launchpad.c: main(675) > pfds[LAUNCH_PAD].revent  : 0x0
11-23 14:05:27.984+0530 D/AUL_PAD ( 1390): launchpad.c: main(677) > pfds[POOL_TYPE + 0].revents : 0x0
11-23 14:05:27.984+0530 D/AUL_PAD ( 1390): launchpad.c: main(678) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
11-23 14:05:27.984+0530 D/AUL_PAD ( 1390): launchpad.c: main(677) > pfds[POOL_TYPE + 1].revents : 0x0
11-23 14:05:27.984+0530 D/AUL_PAD ( 1390): launchpad.c: main(678) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
11-23 14:05:27.984+0530 D/AUL_PAD ( 1390): launchpad.c: main(677) > pfds[POOL_TYPE + 2].revents : 0x1
11-23 14:05:27.984+0530 D/AUL_PAD ( 1390): launchpad.c: main(678) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
11-23 14:05:27.984+0530 D/AUL_PAD ( 1390): launchpad.c: main(717) > pfds[POOL_TYPE + 2].revents & POLLIN
11-23 14:05:27.984+0530 D/AUL     (18761): process_pool.c: __connect_to_launchpad(132) > send(18761) : 4
11-23 14:05:27.984+0530 D/AUL_PAD ( 1390): launchpad.c: main(729) > [SECURE_LOG] Type 2 candidate process was connected, pid: 18761
11-23 14:05:27.984+0530 D/AUL     (18761): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
11-23 14:05:27.984+0530 E/EFL     (18604): ecore_x<18604> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=93146446
11-23 14:05:27.984+0530 E/EFL     (18604): evas_events.c: _evas_canvas_event_feed_mouse_down(1171) > [SECURE_LOG] ButtonEvent:down time=93146446 x=417 y=1191 button=1 downs=0 grabbed=0
11-23 14:05:27.984+0530 E/EFL     (18604): evas_events.c: _evas_canvas_event_feed_mouse_down(1267) > [SECURE_LOG] ButtonEvent:candidate object count=1
11-23 14:05:27.984+0530 E/EFL     (18604): evas_events.c: _evas_input_debug_info(3412) > [SECURE_LOG] [Press] button:1, [417,1191], obj : 0xb7354938, smart : 0x8000ec77, edje, [150,1182,420,78], event:[0,1], time:[93146446]
11-23 14:05:27.984+0530 E/EFL     (18604): evas_events.c: _evas_canvas_event_feed_mouse_down(1306) > [SECURE_LOG] del:0, layer:[0xb721d080,0], 0
11-23 14:05:27.984+0530 D/AUL_AMD (  608): amd_request.c: __add_history_handler(412) > [SECURE_LOG] appid: com.samsung.task-mgr, alias_appid: com.samsung.task-mgr
11-23 14:05:27.984+0530 D/AUL_AMD (  608): amd_request.c: __add_history_handler(434) > [SECURE_LOG] add rua history com.samsung.task-mgr /usr/apps/com.samsung.task-mgr/bin/task-mgr
11-23 14:05:27.984+0530 D/RUA     (  608): rua.c: rua_add_history(179) > rua_add_history start
11-23 14:05:27.994+0530 D/RUA     (  608): rua.c: rua_add_history(247) > rua_add_history ok
11-23 14:05:28.094+0530 E/EFL     (18604): ecore_x<18604> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=93146557
11-23 14:05:28.094+0530 E/EFL     (18604): evas_events.c: _evas_canvas_event_feed_mouse_up(1481) > [SECURE_LOG] ButtonEvent:up time=93146557 x=419 y=1193 button=1 downs=1
11-23 14:05:28.094+0530 E/EFL     (18604): evas_events.c: _evas_input_debug_info(3412) > [SECURE_LOG] [Release] button:1, [419,1193], obj : 0xb7354938, smart : 0x8000ec77, edje, [150,1182,420,78], event:[0,1], time:[93146557]
11-23 14:05:28.104+0530 D/TASK_MGR_LITE(18604): recent_app_viewer.c: on_close_all_clicked(1382) > clicked close all applications button
11-23 14:05:28.104+0530 D/TASK_MGR_LITE(18604): recent_app_viewer.c: close_all_animation(1366) > close_all_animation
11-23 14:05:28.104+0530 D/TASK_MGR_LITE(18604): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.010577
11-23 14:05:28.114+0530 D/TASK_MGR_LITE(18604): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.066017
11-23 14:05:28.134+0530 D/TASK_MGR_LITE(18604): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.121457
11-23 14:05:28.154+0530 D/TASK_MGR_LITE(18604): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.177000
11-23 14:05:28.164+0530 D/TASK_MGR_LITE(18604): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.232440
11-23 14:05:28.184+0530 D/TASK_MGR_LITE(18604): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.287880
11-23 14:05:28.204+0530 D/TASK_MGR_LITE(18604): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.343320
11-23 14:05:28.214+0530 D/TASK_MGR_LITE(18604): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.398863
11-23 14:05:28.234+0530 D/TASK_MGR_LITE(18604): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.454303
11-23 14:05:28.254+0530 D/TASK_MGR_LITE(18604): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.509743
11-23 14:05:28.264+0530 D/TASK_MGR_LITE(18604): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.565287
11-23 14:05:28.284+0530 D/TASK_MGR_LITE(18604): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.620727
11-23 14:05:28.294+0530 D/TASK_MGR_LITE(18604): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.676167
11-23 14:05:28.314+0530 D/TASK_MGR_LITE(18604): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.731607
11-23 14:05:28.314+0530 D/UXT     (18761): uxt_theme_private.c: uxt_theme_get_table_number(634) > index: 999, hsv: 230, 92, 74
11-23 14:05:28.314+0530 D/UXT     (18761): uxt_theme_private.c: uxt_theme_get_table_number(656) > input color table for theme index (999): ChangeableColorTable1.xml
11-23 14:05:28.324+0530 D/UXT     (18761): uxt_theme.c: uxt_theme_add_color_table(620) > color table (b8dd95a8) from (/usr/share/themes/ChangeableColorTable1.xml) is created
11-23 14:05:28.324+0530 D/UXT     (18761): uxt_theme_private.c: uxt_theme_get_core_color_list(1748) > core base color index : 0 (/usr/share/themes/ChangeableColorTable1.xml)
11-23 14:05:28.324+0530 I/UXT     (18761): Uxt_ObjectManager.cpp: OnInitialized(734) > Initialized.
11-23 14:05:28.324+0530 D/TASK_MGR_LITE(18604): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.787147
11-23 14:05:28.334+0530 D/AUL_PAD (18761): launchpad_loader.c: main(620) > [candidate] elm init, returned: 1
11-23 14:05:28.344+0530 D/TASK_MGR_LITE(18604): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.842590
11-23 14:05:28.354+0530 D/TASK_MGR_LITE(18604): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.898030
11-23 14:05:28.374+0530 D/TASK_MGR_LITE(18604): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.953470
11-23 14:05:28.374+0530 E/TBM     (18761): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
11-23 14:05:28.374+0530 I/MALI    (18761): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=18761   open drm_fd=30 
11-23 14:05:28.394+0530 D/TASK_MGR_LITE(18604): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 1.000000
11-23 14:05:28.394+0530 D/TASK_MGR_LITE(18604): recent_app_viewer.c: close_all_animation_cb(1355) > Fade out End !! 
11-23 14:05:28.394+0530 D/TASK_MGR_LITE(18604): recent_app_viewer.c: quit_idler_cb(1323) > Quit idler, call elm_exit()
11-23 14:05:28.394+0530 D/TASK_MGR_LITE(18604): recent_app_viewer.c: show_no_app_label(1399) > show_no_app_label
11-23 14:05:28.404+0530 D/AUL     (18604): app_sock.c: __app_send_raw_with_noreply(387) > pid(-2) : cmd(22)
11-23 14:05:28.404+0530 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 22
11-23 14:05:28.404+0530 W/AUL_AMD (  608): amd_request.c: __request_handler(1201) > app status : 5
11-23 14:05:28.404+0530 D/AUL_AMD (  608): amd_status.c: _status_update_app_info_list(431) > pid(18604) status(5)
11-23 14:05:28.404+0530 D/AUL_AMD (  608): amd_status.c: _status_update_app_info_list(442) > pid(18604) appid(com.samsung.task-mgr) pkgid(com.samsung.task-mgr) status(5)
11-23 14:05:28.404+0530 W/AUL     (  608): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(18604)
11-23 14:05:28.404+0530 W/AUL     (  608): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 18604, appid: com.samsung.task-mgr, status: bg
11-23 14:05:28.404+0530 D/APP_CORE(18604): appcore-efl.c: __check_skip(707) > ret(0), win(7200003), state(0), num(0)
11-23 14:05:28.404+0530 D/APP_CORE(18604): appcore-efl.c: __after_loop(1177) > [APP 18604] PAUSE before termination
11-23 14:05:28.404+0530 I/CAPI_APPFW_APPLICATION(18604): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
11-23 14:05:28.404+0530 D/TASK_MGR_LITE(18604): task-mgr-lite.c: _pause_app(398) > _pause_app
11-23 14:05:28.404+0530 W/TASK_MGR_LITE(18604): task-mgr-lite.c: _pause_app(403) > 
11-23 14:05:28.404+0530 I/CAPI_APPFW_APPLICATION(18604): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
11-23 14:05:28.404+0530 D/TASK_MGR_LITE(18604): task-mgr-lite.c: _terminate_app(348) > _terminate_app
11-23 14:05:28.404+0530 D/TASK_MGR_LITE(18604): task-mgr-lite.c: task_mgr_close_all(106) > task_mgr_close_all
11-23 14:05:28.404+0530 D/TASK_MGR_LITE(18604): recent_apps.c: recent_apps_kill_selected(182) > kill app, appid: org.example.iap-test
11-23 14:05:28.404+0530 D/TASK_MGR_LITE(18604): recent_apps.c: recent_apps_kill_selected(185) > kill app, pid: 18731
11-23 14:05:28.404+0530 D/AUL     (18604): app_sock.c: __app_send_raw(288) > pid(-2) : cmd(14)
11-23 14:05:28.404+0530 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 14
11-23 14:05:28.404+0530 D/AUL_AMD (  608): amd_status.c: _status_app_is_running_from_cache(824) > is_running hit cache, return immediately
11-23 14:05:28.404+0530 D/AUL_AMD (  608): amd_request.c: __request_handler(1173) > [SECURE_LOG] APP_IS_RUNNING : org.example.iap-test : 18731
11-23 14:05:28.404+0530 W/AUL_AMD (  608): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 18731
11-23 14:05:28.404+0530 I/samsung-log-manager( 1449): SLogMgr_UseAppStatusMonitor.cpp: DbusSignalHandlerAppFw(233) > [SECURE_LOG] [(233)]: Background 18604 com.samsung.task-mgr
11-23 14:05:28.404+0530 W/AUL     (18604): launch.c: app_request_to_launchpad(396) > request cmd(4) to(18731)
11-23 14:05:28.404+0530 D/AUL     (18604): app_sock.c: __app_send_raw(288) > pid(-2) : cmd(4)
11-23 14:05:28.404+0530 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 4
11-23 14:05:28.404+0530 D/AUL_AMD (  608): amd_request.c: __app_process_by_pid(308) > [SECURE_LOG] __app_process_by_pid, pid: 18731, 
11-23 14:05:28.404+0530 D/AUL     (  608): app_sock.c: __app_send_raw_with_delay_reply(458) > pid(18731) : cmd(4)
11-23 14:05:28.404+0530 D/AUL_AMD (  608): amd_launch.c: _term_app(1237) > term done
11-23 14:05:28.404+0530 D/APP_CORE(18731): appcore.c: __aul_handler(626) > [APP 18731]     AUL event: AUL_TERMINATE
11-23 14:05:28.404+0530 D/AUL_AMD (  608): amd_launch.c: __set_reply_handler(1186) > listen fd : 42, send fd : 41
11-23 14:05:28.404+0530 I/APP_CORE(18731): appcore-efl.c: __do_app(514) > [APP 18731] Event: TERMINATE State: PAUSED
11-23 14:05:28.404+0530 D/APP_CORE(18731): appcore-efl.c: __do_app(535) > [APP 18731] TERMINATE
11-23 14:05:28.404+0530 D/AUL     (18731): app_sock.c: __app_send_raw_with_noreply(387) > pid(-2) : cmd(22)
11-23 14:05:28.404+0530 W/AUL_AMD (  608): amd_launch.c: __reply_handler(1083) > listen fd(42) , send fd(41), pid(18731), cmd(4)
11-23 14:05:28.404+0530 D/RESOURCED(  667): cgroup.c: cgroup_write_node(133) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 18731
11-23 14:05:28.404+0530 W/AUL     (18604): launch.c: app_request_to_launchpad(425) > request cmd(4) result(0)
11-23 14:05:28.404+0530 D/RESOURCED(  667): net-cls-cgroup.c: place_pids_to_net_cgroup(330) > /proc/18731/task/18731/children of org.example.iap-test is not existed
11-23 14:05:28.404+0530 D/TASK_MGR_LITE(18604): recent_apps.c: kill_pid(93) > terminate pid = 18731
11-23 14:05:28.404+0530 D/RESOURCED(  667): cgroup.c: cgroup_write_node(133) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/net_cls/org.example.iap-test/cgroup.procs, value 18731
11-23 14:05:28.404+0530 D/RUA     (18604): rua.c: rua_delete_history_with_pkgname(91) > rua_delete_history_with_pkgname start
11-23 14:05:28.404+0530 D/RESOURCED(  667): freezer-process.c: freezer_process_pid_set(156) > freezer_process_pid_set 18731
11-23 14:05:28.414+0530 I/samsung-log-manager( 1449): SLogMgr_NativeDbHelper.cpp: ExecQuery(180) > [SECURE_LOG] [(180)]: query tmp [INSERT INTO use_app_survey(app_id,duration,timestamp,time_zone) VALUES ('com.samsung.task-mgr',1397,1448267728424,'Asia/Kolkata');]
11-23 14:05:28.414+0530 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 22
11-23 14:05:28.414+0530 W/AUL_AMD (  608): amd_request.c: __request_handler(1201) > app status : 5
11-23 14:05:28.414+0530 D/AUL_AMD (  608): amd_status.c: _status_update_app_info_list(431) > pid(18731) status(5)
11-23 14:05:28.414+0530 D/AUL     (18731): app_sock.c: __app_send_raw_with_noreply(387) > pid(-2) : cmd(22)
11-23 14:05:28.414+0530 D/AUL_AMD (  608): amd_status.c: _status_update_app_info_list(442) > pid(18731) appid(org.example.iap-test) pkgid(org.example.iap-test) status(5)
11-23 14:05:28.414+0530 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 22
11-23 14:05:28.414+0530 W/AUL_AMD (  608): amd_request.c: __request_handler(1201) > app status : 5
11-23 14:05:28.414+0530 D/AUL_AMD (  608): amd_status.c: _status_update_app_info_list(431) > pid(18731) status(5)
11-23 14:05:28.414+0530 D/AUL_AMD (  608): amd_status.c: _status_update_app_info_list(442) > pid(18731) appid(org.example.iap-test) pkgid(org.example.iap-test) status(5)
11-23 14:05:28.414+0530 D/APP_CORE(18731): appcore-efl.c: __check_skip(707) > ret(1), win(2000003), state(b7d60648), num(1)
11-23 14:05:28.414+0530 D/APP_CORE(18731): appcore-efl.c: __check_skip(710) > state[0] : 9
11-23 14:05:28.424+0530 I/TIZEN_N_EFL_UTIL_WINDOW(18731): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 12
11-23 14:05:28.424+0530 E/APP_CORE(18731): appcore-efl.c: _capture_and_make_file(1619) > win[2000003] widget[720] height[1280]
11-23 14:05:28.424+0530 D/AUL     (18731): app_sock.c: __app_send_raw(288) > pid(-2) : cmd(33)
11-23 14:05:28.424+0530 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 33
11-23 14:05:28.424+0530 E/APP_CORE(18731): appcore-efl.c: _capture_and_make_file(1622) > cannot a capture file for the package of [org.example.iap-test]
11-23 14:05:28.424+0530 I/CAPI_APPFW_APPLICATION(18731): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
11-23 14:05:28.424+0530 D/RUA     (18604): rua.c: rua_delete_history_with_pkgname(124) > rua_delete_history_with_pkgname ok
11-23 14:05:28.424+0530 D/TASK_MGR_LITE(18604): recent_apps.c: recent_apps_kill_selected(199) > End recent_apps_kill_selected, result: 
11-23 14:05:28.424+0530 D/TASK_MGR_LITE(18604): recent_apps.c: recent_apps_kill_selected(182) > kill app, appid: org.tizen.iapsample
11-23 14:05:28.424+0530 D/TASK_MGR_LITE(18604): recent_apps.c: recent_apps_kill_selected(185) > kill app, pid: -1
11-23 14:05:28.424+0530 D/RUA     (18604): rua.c: rua_delete_history_with_pkgname(91) > rua_delete_history_with_pkgname start
11-23 14:05:28.444+0530 D/RUA     (18604): rua.c: rua_delete_history_with_pkgname(124) > rua_delete_history_with_pkgname ok
11-23 14:05:28.444+0530 D/TASK_MGR_LITE(18604): recent_apps.c: recent_apps_kill_selected(199) > End recent_apps_kill_selected, result: 
11-23 14:05:28.444+0530 D/TASK_MGR_LITE(18604): capture_inotify.c: destroy_capture_inotify(148) > finish inotify of /opt/usr/share/app_capture
11-23 14:05:28.444+0530 E/TASK_MGR_LITE(18604): recent_app_viewer.c: destroy_recent_app_viewer(1583) > destroy_recent_app_viewer
11-23 14:05:28.454+0530 D/TASK_MGR_LITE(18604): recent_apps.c: recent_app_list_destroy(635) > recent_app_list_destroy
11-23 14:05:28.454+0530 D/TASK_MGR_LITE(18604): recent_apps.c: list_destroy(374) > START list_destroy
11-23 14:05:28.454+0530 D/TASK_MGR_LITE(18604): recent_apps.c: list_destroy(383) > Free: org.tizen.iapsample
11-23 14:05:28.454+0530 D/TASK_MGR_LITE(18604): recent_apps.c: list_unretrieve_item(215) > Unretrieve app: Sample 1way (org.tizen.iapsample)
11-23 14:05:28.454+0530 D/TASK_MGR_LITE(18604): recent_apps.c: list_destroy(374) > START list_destroy
11-23 14:05:28.454+0530 D/TASK_MGR_LITE(18604): recent_apps.c: list_destroy(383) > Free: org.example.iap-test
11-23 14:05:28.454+0530 D/TASK_MGR_LITE(18604): recent_apps.c: list_unretrieve_item(215) > Unretrieve app: iap-test (org.example.iap-test)
11-23 14:05:28.464+0530 E/APP_CORE(18604): appcore.c: appcore_flush_memory(793) > Appcore not initialized
11-23 14:05:28.464+0530 D/UXT     (18604): uxt_theme.c: uxt_theme_delete_color_table(654) > color table (b70dc698) is freed
11-23 14:05:28.464+0530 D/UXT     (18604): uxt_theme.c: uxt_theme_delete_font_table(1399) > color table (b732e638) is freed
11-23 14:05:28.464+0530 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
11-23 14:05:28.475+0530 W/AUL_AMD (  608): amd_launch.c: __e17_status_handler(3328) > pid(18731) status(3)
11-23 14:05:28.485+0530 I/MALI    (18604): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=18604   close drm_fd=30 
11-23 14:05:28.525+0530 D/AUL_PAD (18761): launchpad_loader.c: main(683) > [candidate] ecore handler add
11-23 14:05:28.525+0530 D/AUL_PAD (18761): launchpad_loader.c: main(697) > [candidate] ecore main loop begin
11-23 14:05:28.525+0530 E/EFL     (18761): edje<18761> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
11-23 14:05:28.525+0530 E/EFL     (18761): By the power of Grayskull, your previous Embryo stack is now broken!
11-23 14:05:28.535+0530 E/EFL     (18761): edje<18761> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
11-23 14:05:28.535+0530 E/EFL     (18761): By the power of Grayskull, your previous Embryo stack is now broken!
11-23 14:05:28.535+0530 E/EFL     (18761): edje<18761> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
11-23 14:05:28.535+0530 E/EFL     (18761): By the power of Grayskull, your previous Embryo stack is now broken!
11-23 14:05:28.675+0530 D/APP_CORE(18604): appcore-efl.c: appcore_efl_main(1678) > [SECURE_LOG] [task-mgr:Application:Terminate]
11-23 14:05:28.705+0530 D/AUL_PAD ( 1390): launchpad.c: main(675) > pfds[LAUNCH_PAD].revent  : 0x0
11-23 14:05:28.705+0530 D/AUL_PAD ( 1390): launchpad.c: main(677) > pfds[POOL_TYPE + 0].revents : 0x0
11-23 14:05:28.705+0530 D/AUL_PAD ( 1390): launchpad.c: main(678) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
11-23 14:05:28.705+0530 D/AUL_PAD ( 1390): launchpad.c: main(677) > pfds[POOL_TYPE + 1].revents : 0x0
11-23 14:05:28.705+0530 D/AUL_PAD ( 1390): launchpad.c: main(678) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
11-23 14:05:28.705+0530 D/AUL_PAD ( 1390): launchpad.c: main(677) > pfds[POOL_TYPE + 2].revents : 0x0
11-23 14:05:28.705+0530 D/AUL_PAD ( 1390): launchpad.c: main(678) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
11-23 14:05:28.705+0530 I/AUL_PAD ( 1390): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 18604 pgid = 18604
11-23 14:05:28.705+0530 I/AUL_PAD ( 1390): sigchild.h: __sigchild_action(143) > dead_pid(18604)
11-23 14:05:28.725+0530 D/AUL_PAD ( 1390): sigchild.h: __send_app_dead_signal(91) > send dead signal done
11-23 14:05:28.725+0530 I/AUL_PAD ( 1390): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
11-23 14:05:28.725+0530 I/AUL_PAD ( 1390): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
11-23 14:05:28.725+0530 E/AUL_PAD ( 1390): launchpad.c: main(698) > error reading sigchld info
11-23 14:05:28.725+0530 D/STARTER ( 2004): lock-daemon-lite.c: lockd_app_dead_cb_lite(1158) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.53/src/lock-daemon-lite.c:1158:D] app dead cb call! (pid : 18604)
11-23 14:05:28.725+0530 I/ESD     (  882): esd_main.c: __esd_app_dead_handler(1773) > pid: 18604
11-23 14:05:28.725+0530 D/STARTER ( 2004): menu_daemon.c: menu_daemon_check_dead_signal(840) > [menu_daemon_check_dead_signal:840] Process 18604 is termianted
11-23 14:05:28.725+0530 I/Tizen::App( 1185): (243) > App[com.samsung.task-mgr] pid[18604] terminate event is forwarded
11-23 14:05:28.725+0530 I/Tizen::System( 1185): (256) > osp.accessorymanager.service provider is found.
11-23 14:05:28.725+0530 I/Tizen::System( 1185): (196) > Accessory Owner is removed [com.samsung.task-mgr, 18604, ]
11-23 14:05:28.725+0530 I/Tizen::System( 1185): (256) > osp.system.service provider is found.
11-23 14:05:28.725+0530 I/Tizen::App( 1185): (506) > TerminatedApp(com.samsung.task-mgr)
11-23 14:05:28.725+0530 I/Tizen::App( 1185): (512) > Not registered pid(18604)
11-23 14:05:28.725+0530 I/Tizen::System( 1185): (246) > Terminated app [com.samsung.task-mgr]
11-23 14:05:28.725+0530 D/STARTER ( 2004): menu_daemon.c: menu_daemon_check_dead_signal(893) > [menu_daemon_check_dead_signal:893] Unknown process, ignore it (dead pid 18604, home pid 1953, taskmgr pid -1)
11-23 14:05:28.725+0530 I/Tizen::Io( 1185): (729) > Entry not found
11-23 14:05:28.725+0530 W/AUL_AMD (  608): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 18604
11-23 14:05:28.725+0530 W/AUL_AMD (  608): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 18604
11-23 14:05:28.725+0530 D/AUL_AMD (  608): amd_key.c: _unregister_key_event(179) > ===key stack===
11-23 14:05:28.725+0530 D/AUL_AMD (  608): amd_status.c: _status_publish_app_status(1132) > [SECURE_LOG] pid(18604) status(0)
11-23 14:05:28.725+0530 D/AUL_AMD (  608): amd_status.c: _status_publish_app_status(1139) > [SECURE_LOG] pid(18604) appid(com.samsung.task-mgr)
11-23 14:05:28.725+0530 D/AUL_AMD (  608): amd_launch.c: __amd_effect_image_file_set(1472) > [SECURE_LOG] path : com.samsung.task-mgr
11-23 14:05:28.725+0530 D/AUL_AMD (  608): amd_launch.c: __amd_send_message_to_e17(1506) > root win : 5a
11-23 14:05:28.725+0530 D/AUL_AMD (  608): amd_launch.c: __amd_send_message_to_e17(1521) > [LAUNCHING EFFECT]: message type(0), screen mode(0), effect type(-1), theme(0), indicator hide
11-23 14:05:28.725+0530 D/AUL_AMD (  608): amd_launch.c: __amd_send_message_to_e17(1528) > ecore_x_client_message32_send : 1
11-23 14:05:28.725+0530 D/AUL_AMD (  608): amd_status.c: _status_publish_app_status(1160) > [SECURE_LOG] appid(com.samsung.camera-app-lite)
11-23 14:05:28.725+0530 D/AUL_AMD (  608): amd_status.c: __remove_pkg_info(262) > ~STATUS_SERVICE : appid(com.samsung.task-mgr)
11-23 14:05:28.725+0530 D/AUL     (  608): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
11-23 14:05:28.725+0530 D/AUL     (  608): simple_util.c: __trm_app_info_send_socket(354) > send
11-23 14:05:28.735+0530 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1818
11-23 14:05:28.735+0530 D/RESOURCED(  667): proc-monitor.c: proc_dbus_aul_terminated(1119) > received terminated process : pid 18604
11-23 14:05:28.735+0530 I/Tizen::System( 1185): (157) > change brightness system value.
11-23 14:05:28.735+0530 I/Tizen::App( 1185): (782) > Finished invoking application event listener for com.samsung.task-mgr, 18604.
11-23 14:05:28.765+0530 D/RESOURCED(  667): appinfo-list.c: resourced_appinfo_put(132) > appid com.samsung.task-mgr, pkgname = com.samsung.task-mgr, ref = 0
11-23 14:05:28.765+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-23 14:05:28.765+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-23 14:05:28.765+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-23 14:05:28.765+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-23 14:05:28.835+0530 E/EFL     (  351): ecore_x<351> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=93147308
11-23 14:05:28.845+0530 E/EFL     (  351): ecore_x<351> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=93147308
11-23 14:05:28.845+0530 E/EFL     (  351): evas_events.c: _evas_canvas_event_feed_mouse_down(1171) > [SECURE_LOG] ButtonEvent:down time=93147308 x=35 y=364 button=1 downs=0 grabbed=0
11-23 14:05:28.845+0530 E/EFL     (  351): evas_events.c: _evas_canvas_event_feed_mouse_down(1267) > [SECURE_LOG] ButtonEvent:candidate object count=0
11-23 14:05:28.895+0530 E/EFL     (  351): ecore_x<351> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=93147363
11-23 14:05:29.335+0530 W/CRASH_MANAGER(18772): worker.c: worker_job(1199) > 0618731696170144826772
