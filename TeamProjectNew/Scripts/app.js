/*
 * Mudrak Patel and Javid Niftaliyeve
 * Comp229 project
 */

/* custom JavaScript goes here */
(function () {
    console.log("app.js trigerred...");
    wallpaperSwitcher();
}());
/**
 * @method wallpaperSwitcher
 * @void
 * @param null
 */
function wallpaperSwitcher() {
    switch (document.title) {
        case "Counter Strike": document.body.style.backgroundImage = "url(../Assets/Images/counterstrikePageWallpaper.jpg)";
            break;
        case "Battle Field": document.body.style.backgroundImage = "url(../Assets/Images/battlefieldPageWallpaper.jpg)";
            break;
        case "Call of Duty": document.body.style.backgroundImage = "url(../Assets/Images/callofdutyPageWallpaper.jpg)";
            break;
        case "Fifa 17": document.body.style.backgroundImage = "url(../Assets/Images/fifaPageWallpaper.jpg)";
            break;
        case "Home": document.body.style.backgroundImage = "url(../Assets/Images/DefaultPageWallpaper.jpg)";
            break;
        case "Login": document.body.style.backgroundImage = "url(../Assets/Images/LoginPageWallpaper.jpg)";
            break;
        case "Register": document.body.style.backgroundImage = "url(../Assets/Images/RegisterPageWallpaper.jpg)";
            document.body.style.backgroundSize = "1920px 900px";
            document.body.style.backgroundPosition = "center";
            break;
        default: console.log("Programmer has not loaded any background image for default case.\n");
            break;
    }
}