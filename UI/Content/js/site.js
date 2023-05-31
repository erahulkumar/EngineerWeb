document.getElementById("AloginForm").addEventListener("submit", function (event) {
    event.preventDefault(); // Prevent form submission

    // Get form values
    var username = document.getElementById("username").value;
    var password = document.getElementById("password").value;

    // Perform login validation (example)
    if (username === "admin" && password === "password") {
        alert("Login successful!");
        // Perform further actions (e.g., redirect to dashboard)
    } else {
        alert("Invalid username or password. Please try again.");
    }
});