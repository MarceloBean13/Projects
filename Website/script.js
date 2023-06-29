const hamBar = document.getElementById("ham-icon");
const nav = document.getElementById("navbar");
const close = document.getElementById("close-icon")

if (hamBar) {
    hamBar.addEventListener("click", () =>{
        nav.classList.add("active");
    });
}

if (close){
    close.addEventListener("click", () => {
        nav.classList.remove("active");
    })
}