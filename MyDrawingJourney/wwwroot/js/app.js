window.addEventListener('load', solve);

function solve() {
    let likeBtn = document.querySelectorAll('#like-btn');
    let likeP = document.getElementById('like');
    let likedSong = 0;

    
    for (var i = 0; i < likeBtn.length; i++) {
        likeBtn[i].addEventListener("click", onLike);
    }
    function onLike() {
        likeP.textContent = `Total Likes: ${++likedSong}`
    }
}