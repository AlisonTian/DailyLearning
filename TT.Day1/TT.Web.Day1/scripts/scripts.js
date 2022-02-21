document.getElementById('btn').addEventListener("click", myClick);

function myClick() {
    alert("clicked");
}
function myAppend() {
    let p = document.createElement("p")
    document.getElementById('append-area').append('new line', p);
}