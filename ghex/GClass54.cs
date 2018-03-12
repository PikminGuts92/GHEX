using System;
using System.Runtime.InteropServices;

public sealed class GClass54
{
	GClass54()
	{
	}

	[DllImport("WMVCore.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	static extern int WMCreateReader(IntPtr intptr_0, GEnum23 genum23_0, [MarshalAs(UnmanagedType.Interface)] out GInterface30 ginterface30_0);

	[DllImport("WMVCore.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	static extern int WMCreateSyncReader(IntPtr intptr_0, GEnum23 genum23_0, [MarshalAs(UnmanagedType.Interface)] out GInterface27 ginterface27_0);

	[DllImport("WMVCore.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, EntryPoint = "WMCreateSyncReader", ExactSpelling = true, SetLastError = true)]
	static extern int WMCreateSyncReader_1([MarshalAs(UnmanagedType.Interface)] out GInterface42 ginterface42_1);

	[DllImport("WMVCore.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	static extern int WMCreateEditor([MarshalAs(UnmanagedType.Interface)] out GInterface22 ginterface22_0);

	[DllImport("WMVCore.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	static extern int WMCreateIndexer([MarshalAs(UnmanagedType.Interface)] out GInterface24 ginterface24_0);

	[DllImport("WMVCore.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	static extern int WMIsAvailableOffline([MarshalAs(UnmanagedType.LPWStr)] [In] string string_180, [MarshalAs(UnmanagedType.LPWStr)] [In] string string_181, [MarshalAs(UnmanagedType.Bool)] out bool bool_0);

	[DllImport("WMVCore.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	static extern int WMIsContentProtected([MarshalAs(UnmanagedType.LPWStr)] [In] string string_180, [MarshalAs(UnmanagedType.Bool)] out bool bool_0);

	[DllImport("WMVCore.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	static extern int WMValidateData([MarshalAs(UnmanagedType.LPArray)] [In] byte[] byte_0, [In] [Out] ref uint uint_3);

	[DllImport("WMVCore.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	static extern int WMCheckURLExtension([MarshalAs(UnmanagedType.LPWStr)] [In] string string_180);

	[DllImport("WMVCore.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	static extern int WMCheckURLScheme([MarshalAs(UnmanagedType.LPWStr)] [In] string string_180);

	public static GInterface30 smethod_0(GEnum23 genum23_0)
	{
		GInterface30 result = null;
		Marshal.ThrowExceptionForHR(GClass54.WMCreateReader(IntPtr.Zero, genum23_0, out result));
		return result;
	}

	public static GInterface27 smethod_1(GEnum23 genum23_0)
	{
		GInterface27 result = null;
		Marshal.ThrowExceptionForHR(GClass54.WMCreateSyncReader(IntPtr.Zero, genum23_0, out result));
		return result;
	}

	public static GInterface42 smethod_2()
	{
		GInterface42 result = null;
		Marshal.ThrowExceptionForHR(GClass54.WMCreateSyncReader_1(out result));
		return result;
	}

	public static GInterface22 smethod_3()
	{
		GInterface22 result = null;
		Marshal.ThrowExceptionForHR(GClass54.WMCreateEditor(out result));
		return result;
	}

	public static GInterface24 smethod_4()
	{
		GInterface24 result = null;
		Marshal.ThrowExceptionForHR(GClass54.WMCreateIndexer(out result));
		return result;
	}

	public static bool smethod_5(string string_180, string string_181)
	{
		bool result = false;
		Marshal.ThrowExceptionForHR(GClass54.WMIsAvailableOffline(string_180, string_181, out result));
		return result;
	}

	public static bool smethod_6(string string_180)
	{
		bool result = false;
		Marshal.ThrowExceptionForHR(GClass54.WMIsContentProtected(string_180, out result));
		return result;
	}

	public static void smethod_7(byte[] byte_0)
	{
		uint num = (uint)byte_0.Length;
		Marshal.ThrowExceptionForHR(GClass54.WMValidateData(byte_0, ref num));
	}

	public static uint smethod_8()
	{
		uint result = 0u;
		Marshal.ThrowExceptionForHR(GClass54.WMValidateData(null, ref result));
		return result;
	}

	public static bool smethod_9(string string_180)
	{
		return GClass54.WMCheckURLExtension(string_180) == 0;
	}

	public static bool smethod_10(string string_180)
	{
		return GClass54.WMCheckURLScheme(string_180) == 0;
	}

	public static GInterface42 smethod_11()
	{
		if (GClass54.ginterface42_0 == null)
		{
			GClass54.ginterface42_0 = GClass54.smethod_2();
			GInterface43 ginterface = (GInterface43)GClass54.ginterface42_0;
			ginterface.imethod_13(GEnum16.const_3);
		}
		return GClass54.ginterface42_0;
	}

	public const int int_0 = -1072886833;

	public const int int_1 = -1072887824;

	public const uint uint_0 = 20u;

	public const string string_0 = "Duration";

	public const string string_1 = "Bitrate";

	public const string string_2 = "Seekable";

	public const string string_3 = "Stridable";

	public const string string_4 = "Broadcast";

	public const string string_5 = "Is_Protected";

	public const string string_6 = "Is_Trusted";

	public const string string_7 = "Signature_Name";

	public const string string_8 = "HasAudio";

	public const string string_9 = "HasImage";

	public const string string_10 = "HasScript";

	public const string string_11 = "HasVideo";

	public const string string_12 = "CurrentBitrate";

	public const string string_13 = "OptimalBitrate";

	public const string string_14 = "HasAttachedImages";

	public const string string_15 = "Can_Skip_Backward";

	public const string string_16 = "Can_Skip_Forward";

	public const string string_17 = "NumberOfFrames";

	public const string string_18 = "FileSize";

	public const string string_19 = "HasArbitraryDataStream";

	public const string string_20 = "HasFileTransferStream";

	public const string string_21 = "WM/ContainerFormat";

	public const uint uint_1 = 5u;

	public const string string_22 = "Title";

	public const string string_23 = "Author";

	public const string string_24 = "Description";

	public const string string_25 = "Rating";

	public const string string_26 = "Copyright";

	public const string string_27 = "Use_DRM";

	public const string string_28 = "DRM_Flags";

	public const string string_29 = "DRM_Level";

	public const string string_30 = "Use_Advanced_DRM";

	public const string string_31 = "DRM_KeySeed";

	public const string string_32 = "DRM_KeyID";

	public const string string_33 = "DRM_ContentID";

	public const string string_34 = "DRM_IndividualizedVersion";

	public const string string_35 = "DRM_LicenseAcqURL";

	public const string string_36 = "DRM_V1LicenseAcqURL";

	public const string string_37 = "DRM_HeaderSignPrivKey";

	public const string string_38 = "DRM_LASignaturePrivKey";

	public const string string_39 = "DRM_LASignatureCert";

	public const string string_40 = "DRM_LASignatureLicSrvCert";

	public const string string_41 = "DRM_LASignatureRootCert";

	public const string string_42 = "WM/AlbumTitle";

	public const string string_43 = "WM/Track";

	public const string string_44 = "WM/PromotionURL";

	public const string string_45 = "WM/AlbumCoverURL";

	public const string string_46 = "WM/Genre";

	public const string string_47 = "WM/Year";

	public const string string_48 = "WM/GenreID";

	public const string string_49 = "WM/MCDI";

	public const string string_50 = "WM/Composer";

	public const string string_51 = "WM/Lyrics";

	public const string string_52 = "WM/TrackNumber";

	public const string string_53 = "WM/ToolName";

	public const string string_54 = "WM/ToolVersion";

	public const string string_55 = "IsVBR";

	public const string string_56 = "WM/AlbumArtist";

	public const string string_57 = "BannerImageType";

	public const string string_58 = "BannerImageData";

	public const string string_59 = "BannerImageURL";

	public const string string_60 = "CopyrightURL";

	public const string string_61 = "AspectRatioX";

	public const string string_62 = "AspectRatioY";

	public const string string_63 = "ASFLeakyBucketPairs";

	public const uint uint_2 = 5u;

	public const string string_64 = "NSC_Name";

	public const string string_65 = "NSC_Address";

	public const string string_66 = "NSC_Phone";

	public const string string_67 = "NSC_Email";

	public const string string_68 = "NSC_Description";

	public const string string_69 = "WM/Writer";

	public const string string_70 = "WM/Conductor";

	public const string string_71 = "WM/Producer";

	public const string string_72 = "WM/Director";

	public const string string_73 = "WM/ContentGroupDescription";

	public const string string_74 = "WM/SubTitle";

	public const string string_75 = "WM/PartOfSet";

	public const string string_76 = "WM/ProtectionType";

	public const string string_77 = "WM/VideoHeight";

	public const string string_78 = "WM/VideoWidth";

	public const string string_79 = "WM/VideoFrameRate";

	public const string string_80 = "WM/MediaClassPrimaryID";

	public const string string_81 = "WM/MediaClassSecondaryID";

	public const string string_82 = "WM/Period";

	public const string string_83 = "WM/Category";

	public const string string_84 = "WM/Picture";

	public const string string_85 = "WM/Lyrics_Synchronised";

	public const string string_86 = "WM/OriginalLyricist";

	public const string string_87 = "WM/OriginalArtist";

	public const string string_88 = "WM/OriginalAlbumTitle";

	public const string string_89 = "WM/OriginalReleaseYear";

	public const string string_90 = "WM/OriginalFilename";

	public const string string_91 = "WM/Publisher";

	public const string string_92 = "WM/EncodedBy";

	public const string string_93 = "WM/EncodingSettings";

	public const string string_94 = "WM/EncodingTime";

	public const string string_95 = "WM/AuthorURL";

	public const string string_96 = "WM/UserWebURL";

	public const string string_97 = "WM/AudioFileURL";

	public const string string_98 = "WM/AudioSourceURL";

	public const string string_99 = "WM/Language";

	public const string string_100 = "WM/ParentalRating";

	public const string string_101 = "WM/BeatsPerMinute";

	public const string string_102 = "WM/InitialKey";

	public const string string_103 = "WM/Mood";

	public const string string_104 = "WM/Text";

	public const string string_105 = "WM/DVDID";

	public const string string_106 = "WM/WMContentID";

	public const string string_107 = "WM/WMCollectionID";

	public const string string_108 = "WM/WMCollectionGroupID";

	public const string string_109 = "WM/UniqueFileIdentifier";

	public const string string_110 = "WM/ModifiedBy";

	public const string string_111 = "WM/RadioStationName";

	public const string string_112 = "WM/RadioStationOwner";

	public const string string_113 = "WM/PlaylistDelay";

	public const string string_114 = "WM/Codec";

	public const string string_115 = "WM/DRM";

	public const string string_116 = "WM/ISRC";

	public const string string_117 = "WM/Provider";

	public const string string_118 = "WM/ProviderRating";

	public const string string_119 = "WM/ProviderStyle";

	public const string string_120 = "WM/ContentDistributor";

	public const string string_121 = "WM/SubscriptionContentID";

	public const string string_122 = "WM/WMADRCPeakReference";

	public const string string_123 = "WM/WMADRCPeakTarget";

	public const string string_124 = "WM/WMADRCAverageReference";

	public const string string_125 = "WM/WMADRCAverageTarget";

	public const string string_126 = "EarlyDataDelivery";

	public const string string_127 = "JustInTimeDecode";

	public const string string_128 = "SingleOutputBuffer";

	public const string string_129 = "SoftwareScaling";

	public const string string_130 = "DeliverOnReceive";

	public const string string_131 = "ScrambledAudio";

	public const string string_132 = "DedicatedDeliveryThread";

	public const string string_133 = "EnableDiscreteOutput";

	public const string string_134 = "SpeakerConfig";

	public const string string_135 = "DynamicRangeControl";

	public const string string_136 = "AllowInterlacedOutput";

	public const string string_137 = "VideoSampleDurations";

	public const string string_138 = "StreamLanguage";

	public const string string_139 = "DeinterlaceMode";

	public const string string_140 = "InitialPatternForInverseTelecine";

	public const string string_141 = "JPEGCompressionQuality";

	public const string string_142 = "WatermarkCLSID";

	public const string string_143 = "WatermarkConfig";

	public const string string_144 = "InterlacedCoding";

	public const string string_145 = "FixedFrameRate";

	public const string string_146 = "_SOURCEFORMATTAG";

	public const string string_147 = "_ORIGINALWAVEFORMAT";

	public const string string_148 = "_EDL";

	public const string string_149 = "_COMPLEXITYEX";

	public const string string_150 = "_DECODERCOMPLEXITYPROFILE";

	public const string string_151 = "ReloadIndexOnSeek";

	public const string string_152 = "StreamNumIndexObjects";

	public const string string_153 = "FailSeekOnError";

	public const string string_154 = "PermitSeeksBeyondEndOfStream";

	public const string string_155 = "UsePacketAtSeekPoint";

	public const string string_156 = "SourceBufferTime";

	public const string string_157 = "SourceMaxBytesAtOnce";

	public const string string_158 = "_VBRENABLED";

	public const string string_159 = "_VBRQUALITY";

	public const string string_160 = "_RMAX";

	public const string string_161 = "_BMAX";

	public const string string_162 = "VBR Peak";

	public const string string_163 = "Buffer Average";

	public const string string_164 = "_COMPLEXITYEXMAX";

	public const string string_165 = "_COMPLEXITYEXOFFLINE";

	public const string string_166 = "_COMPLEXITYEXLIVE";

	public const string string_167 = "_ISVBRSUPPORTED";

	public const string string_168 = "_PASSESUSED";

	public const string string_169 = "MusicSpeechClassMode";

	public const string string_170 = "MusicClassMode";

	public const string string_171 = "SpeechClassMode";

	public const string string_172 = "MixedClassMode";

	public const string string_173 = "SpeechFormatCap";

	public const string string_174 = "PeakValue";

	public const string string_175 = "AverageLevel";

	public const string string_176 = "Fold6To2Channels3";

	public const string string_177 = "Fold%luTo%luChannels%lu";

	public const string string_178 = "DeviceConformanceTemplate";

	public const string string_179 = "EnableFrameInterpolation";

	static GInterface42 ginterface42_0;
}
