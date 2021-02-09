export function preventDefaultKeyBehaviorOnKeys(arrayOfKeyStrings) {    
    var preventDefaultOnKeysFunction = function (e) {        
        if (arrayOfKeyStrings.includes(e.key)) {
            e.preventDefault();
            return false;
        }
    }
    window.addEventListener('keydown', preventDefaultOnKeysFunction, false);
    window.addEventListener('keyup', preventDefaultOnKeysFunction, false);    
}