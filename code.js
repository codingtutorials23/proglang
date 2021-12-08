const bodyError = {
  isError:false,
  isErrorTrue:function(){
    if(document.body.onerror){alert("error")}
  }
}
const checkError = Object.create(bodyError)
checkError.isErrorTrue();
var False = false;
var True =  true;
var x = True;
var message = alert;
message(False)
var x = False;
