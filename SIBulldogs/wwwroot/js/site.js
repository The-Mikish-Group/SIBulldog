// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

//***********************************************//
//  Function used to open Web Page in new Tab    //
//***********************************************//
function newTab(tabURL) {
    let newWindowTab = window.open(tabURL, "_blank");
};

//***********************************************//
//  Create Folder List of File Items             //
//***********************************************//
function createFolderList(folderURL, filecount, extension, imageWidth, imageHeight) {

    extension = extension.toLowerCase();
        
    if (filecount > 0) {

        let fullFileName = "";
        let htmlString = "";
        let altText = "";
        
        let i = 1;
        while (i <= filecount) {
            altText = "";
            altText = altText.concat("00".concat(i).slice(-3)) + extension;
            fullFileName = folderURL + altText;            

            if (extension == ".mp4") {

                // Display Video (.mp4)
                htmlString += "<div class='col-12 col-lg-4 text-center py-2'>" +
                    "<a href='" + fullFileName + "' target='_blank'>" +
                    "<video width=" + imageWidth +
                    " height=" + imageHeight +
                    " class='img-fluid bg-white border border-black h-100 p-2'" +
                    " controls preload='metadata'>" +                    
                    "<source src='" + fullFileName + "#t=1.5' type='video/mp4'>" +
                    "</video>" + 
                    "</div>";

            } else {

                // Display Picture (.jpg)
                htmlString += "<div class='col-12 col-lg-3 text-center py-2'>" +
                    "<a href='" + fullFileName + "' target='_blank'>" +
                    "<img width=" + imageWidth +
                    " height=" + imageHeight +
                    " class='img-fluid bg-white border border-black h-100 p-2'" +
                    " src='" + fullFileName + "'" +
                    " alt='" + altText + "'/> " +
                    "</a>" +
                    "</div>";
                    
            } 

            i++;

        };

        document.getElementById("imagelist").innerHTML = htmlString;

    };

}

//***********************************************//
//  Create Image List of Carousel Items          //
//***********************************************//
function createCarouselList(imageLocation, imageCount) {

    var text = "";
    var altText = ""
    var i = imageCount;

    // Create the needed "active" element
    text = "<div class='carousel-item active'><img class='d-block w-100' src='" + imageLocation.concat("000000".concat(i).slice(-6)) + ".jpg' alt='" + altText.concat("000000".concat(i).slice(-6)) + "' /></div>";
    i--;
    
    // Add the rest of the elements
    while (i > 0) {
        text += "<div class='carousel-item'><img class='d-block w-100' src='" + imageLocation.concat("000000".concat(i).slice(-6)) + ".jpg' alt='" + altText.concat("000000".concat(i).slice(-6)) + "' /></div>";
        i--;
    }

    document.getElementById("CarouselItems").innerHTML = text;

}

//***********************************************//
//  Change background Color                           //
//***********************************************//
function changeBackgroundColor(newBackgroundcolor) {
    $('body').css('background-color', newBackgroundcolor);
}

//***********************************************//
//  Change background Image                      //
//***********************************************//
function changeBackgroundImage(newBackgroundImage) {
    $('body').css('background-image', newBackgroundImage);
}




