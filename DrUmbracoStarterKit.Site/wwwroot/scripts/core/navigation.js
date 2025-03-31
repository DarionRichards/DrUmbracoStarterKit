const burgerMenu = document.getElementById("burger-menu")

// Function to handle burgerMenu active state
const handleActiveClass = () => {
    if (burgerMenu.classList.contains("active")) {
        burgerMenu.classList.remove("active")
    } else {
        burgerMenu.classList.add("active")
    }
}

// Click event for burger nav animation.
burgerMenu.addEventListener("click", handleActiveClass)