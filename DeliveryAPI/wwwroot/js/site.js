// Interacciones de la interfaz y animaciones sutiles
document.addEventListener('DOMContentLoaded', () => {
    console.log('DeliveryAPI MVC Loaded successfully');

    // Resaltar enlace de navegación activo basado en la URL
    const currentPath = window.location.pathname;
    const navLinks = document.querySelectorAll('.nav-links a');
    
    navLinks.forEach(link => {
        const linkPath = link.getAttribute('href');
        if (linkPath === currentPath || (currentPath.startsWith(linkPath) && linkPath !== '/')) {
            link.parentElement.classList.add('active');
        } else {
            link.parentElement.classList.remove('active');
        }
    });

    // Agregar animación de rebote a las tarjetas al hacer clic (micro-interacción)
    const cards = document.querySelectorAll('.feature-card, .glass-card');
    cards.forEach(card => {
        card.addEventListener('mousedown', () => {
            card.style.transform = 'scale(0.98) translateY(0px)';
        });
        card.addEventListener('mouseup', () => {
            card.style.transform = '';
        });
        card.addEventListener('mouseleave', () => {
            card.style.transform = '';
        });
    });
});
