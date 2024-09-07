document.addEventListener('DOMContentLoaded', () => {
        const menuToggle = document.querySelector('.menu-toggle');
        const drawer = document.querySelector('.drawer');
        const closeBtn = document.querySelector('.drawer .close-btn');

        menuToggle.addEventListener('click', () => {
            drawer.classList.add('open');
        });

        closeBtn.addEventListener('click', () => {
            drawer.classList.remove('open');
        });

        // Close drawer when clicking outside of it
        document.addEventListener('click', (e) => {
            if (!drawer.contains(e.target) && !menuToggle.contains(e.target)) {
                drawer.classList.remove('open');
            }
        });
    });
