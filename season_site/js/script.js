function getSeason(){
    var temp = document.getElementById('temp').value;
    //alert('Temp is  ' + temp);

    //goal: send a request which looks like this:
    //http://localhost:64422/api/SeasonAPI/getSeason/6

    var URL = "http://localhost:64422/api/SeasonAPI/getSeason/"+temp;

    var rq= new XMLHttpRequest();
    //where is this request sent to? url above
    //is the method GET or POST? GET method
    //what should we do with the response?  response webpage

    //callback function: 
    rq.open("GET", URL, true);
    rq.onreadystatechange = function(){
        //readystate should be 4 - this means that the request is finished and response is ready
        //AND status should be 200 = "ok"
        if (rq.readyState==4 && rq.statue==200){
            //request is finished
            
            //console.log(rq.reponseText) 
            //this is used to test connection from js to cors - check in console. If connected
            //then delete the line 

            var Season = JSON.parse(rq.responseText); //reponseTExt is a string

            document.getElementById('SeasonContainer').style.display = "block";

            console.log(Season.SeasonName);
            console.log(Season.PhotographerName);
            console.log(Season.ImageURL);
            console.log(Season.Temperature);

            //Client-side rendering
            document.getElementById('PhotographerName').innerHTML=Season.PhotographerName;
            document.getElementById('SeasonName').innerHTML=Season.SeasonName;
            document.getElementById('Temperature').innerHTML=Season.Temperature;
            document.getElementById('Image').src="images/"+Season.SeasonName+".jpg";
            document.getElementById('PhotoLink').href=Season.ImageURL;  //season.ImageURL is the link retreived from the webserver
        } 
    }
    //where the request is being sent to and the method: GET
    
    rq.send();
}
