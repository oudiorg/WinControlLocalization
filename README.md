# WinControlLocalization

* `WinFormLocalization` Winform Project
	* Form1 -> UserControl1
* `WinControlLocalization` UserControl Project
	* Resources.resx
		* Resources.en-US.resx
		* Resources.zh-CN.resx
	* UserControl1
		* TextLocalization -> SRDescription
			* SR->GetString
			* ResourceManager->GetString(resourceName,culture)