

var mhProtocol = ((document.location.protocol == "https:") ? "https://" : "http://");

var mhRand = new Date().getTime();

document.write(unescape("%3Cscript"

+ " src='" + mhProtocol + "www.dynamicnumbers.mediahawk.co.uk/getVisitorParams.js?mhRand=" + mhRand + "'"

+ " type='text/javascript'%3E%3C/script%3E"));



var mhAccountRef = "VA-12684";

document.write(unescape("%3Cscript"

+ " src='" + mhProtocol + "www.dynamicnumbers.mediahawk.co.uk/getVisitorNumber.php"

+ "?mhAccountRef=" + mhAccountRef + mhUrlParamString + "&mhRand=" + mhRand + "'"

+ "type='text/javascript'%3E%3C/script%3E"));

try { mhChangeTelNumber(); }

catch (err) { }