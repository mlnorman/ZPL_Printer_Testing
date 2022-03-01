# ZPL_Printer_Testing
Winforms app to test ZPL Labels.  Similar to the ZPL Printer chrome extension

## Run
* Clone repo
* Navigate to directory with the solution
* Run nuget restore or nuget install
* For testing you can launch the exe from bin/debug/net50-windows

### Saved formats
Commonly used label format can be saved for future use

* Click actions -> One is already created for you when the app is initially launched.
* To edit: Click Actions -> Config
* Here you can set default IP, port, label path, bitonal and whether or not to save labels.

#### Note
* Labelary is being used to return PNGs of the requested label. They have an image buffer limit of 10mb.
  Using Bitonal will slightly decrease image quality but will also make the image size smaller.  This 
  is benificial when testing against relatively large labels. 


#### More and better documentation to come...

