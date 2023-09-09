/* Reset some default styles */
body, h1, h2, h3, p {
    margin: 0;
    padding: 0;
}

/* Apply some basic styling */
body {
    font-family: Arial, sans-serif;
}

header {
    background-color: #333;
    color: #fff;
    padding: 20px;
    display: flex;
    justify-content: space-between;
    align-items: center;
}

nav ul {
    list-style: none;
}

nav ul li {
    display: inline;
    margin-right: 20px;
}

nav ul li:last-child {
    margin-right: 0;
}

.main {
    padding: 20px;
}

.hero {
    background-image: url('shipping-image.jpg');
    background-size: cover;
    text-align: center;
    padding: 100px 0;
    color: #fff;
}

.hero h2 {
    font-size: 36px;
    margin-bottom: 20px;
}

.btn {
    background-color: #f90;
    color: #fff;
    padding: 10px 20px;
    text-decoration: none;
    font-weight: bold;
    border-radius: 5px;
}

.services {
    display: flex;
    justify-content: space-around;
    align-items: center;
    flex-wrap: wrap;
    margin-top: 40px;
}

.service {
    text-align: center;
    max-width: 300px;
    margin: 20px;
}

.service img {
    width: 100px;
    height: 100px;
}

/* Add more styles as needed */

footer {
    background-color: #333;
    color: #fff;
    text-align: center;
    padding: 10px 0;
}

