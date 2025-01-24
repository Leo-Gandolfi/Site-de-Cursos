document.addEventListener('DOMContentLoaded', function () {
    const themeToggle = document.getElementById('themeToggle');
    const root = document.body; 
    const main = document.querySelector('main'); // Seleciona o elemento <main>
   
    const savedTheme = localStorage.getItem('theme') || 'light';
    root.classList.toggle('dark', savedTheme === 'dark');
    if (main) {
        main.classList.toggle('dark', savedTheme === 'dark');
    }

    themeToggle.textContent = savedTheme === 'dark' ? '☀️' : '🌙';

    themeToggle.addEventListener('click', function () {
        const isDarkMode = root.classList.toggle('dark');
        if (main) {
            main.classList.toggle('dark', isDarkMode);
        }
        const newTheme = isDarkMode ? 'dark' : 'light';
        localStorage.setItem('theme', newTheme);

        themeToggle.textContent = isDarkMode ? '☀️' : '🌙';
    });
});