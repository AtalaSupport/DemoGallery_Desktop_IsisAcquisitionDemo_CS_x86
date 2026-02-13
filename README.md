# IsisAcquisitionDemo
Basic scanner selection and acquisition using Atalasoft's ISIS components.

This is a slightly scaled down ISIS version of our TWAIN Acquisition Demo. Its main 
purpose is to demonstrate the basics of how select from available ISIS scanners, and 
how to control various basic settings like pixel format, resolution, and whether or 
not to show the device's default scanning dialog.

The source code should provide a solid foundation in understanding how to work with 
our ISIS scanning components, while the running demo provides a quick means to 
'sanity check' whether your scanner is visible to DotImage.

This is the C# version

## IMPORTANT NOTES
There is no x64 version. This is due to our licensing agreement for the Pixtran resources we ship with our SDK

## Prerequisites
### SDK and licensing
This demo assumes you have the Atalasoft SDK DotImage SDK along with our ISIS Scanning addon installed and 
licensed (or you can request a 30 day evaluation when installing/activating)

[Download DotImage](https://www.atalasoft.com/BeginDownload/DotImageDownloadPage)

### Pixtran resources
In order to use our ISIS components, you must place the Pixtran resources included with our SDK into the correct location

Please see [INFO: ISIS Scanning Requires PIXTRAN Capture Resources](https://www.atalasoft.com/kb2/KB/50146/INFO-ISIS-Scanning-Requires-PIXTRAN-Capture-Resources) for details

## Cloning
We recommend cloning to your local machine

Example: git for windows
```bash
git clone https://github.com/AtalaSupport/DemoGallery_Desktop_IsisAcquisisionDemo_CS_x86.git IsisAcquisitionDemo
```
