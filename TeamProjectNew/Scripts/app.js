/*
 * Mudrak Patel and Javid Niftaliyeve
 * Comp229 project
 */

/* custom JavaScript goes here */
$(document).ready(function () {

    wallpaperSwitcher();

    $("a.btn.btn-danger.btn-sm").click(function () {
        return confirm("Are you sure you want to delete this record?");
    });
});

function wallpaperSwitcher() {
    switch(document.title){
        case "Home": document.body.style.backgroundImage = "url(../Assets/Images/DefaultPageWallpaper.jpg)";
            break;
        case "Battle Field": document.body.style.backgroundImage = "url(../Assets/Images/battlefieldPageWallpaper.jpg)";
            break;
        case "Call of Duty": document.body.style.backgroundImage = "url(../Assets/Images/callofdutyPageWallpaper.jpg)";
            break;
        case "Counter Strike": document.body.style.backgroundImage = "url(../Assets/Images/counterstrikePageWallpaper.jpg)";
            break;
        case "Fifa 17": document.body.style.backgroundImage = "url(../Assets/Images/fifaPageWallpaper.jpg)";
            break;
    }
}