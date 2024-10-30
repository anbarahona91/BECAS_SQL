/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
        './Pages/**/*.cshtml',
        './Views/**/*.cshtml'
    ],
    theme: {
        extend: {
            colors: {
                transparent: 'transparent',
                current: 'currentColor',
                clifford: '#000000',
               
                azulBecas: 'rgb(31 66 136/1)',
                
                aquaBecas: 'rgb(50 193 177/1)',
                
                naranjaBecas: 'rgb(254 177 90/1)',
               
                naranja2Becas: 'rgb(255 237 213/1)',
                moradoBecas: 'rgb(94 93 156/1)',
                
                celesteBecas: 'rgb(59 200 234/1)',
                azul2Becas: '#4b72a9',
                morado2Becas: '#967cb5',
               
                aqua2Becas: 'rgb(93 184 127/1)',
                azul3Becas: '#134289',
                lilaBecas: '#a24c71'
            },
            backgroundImage: {
                'logo-pattern': "url('/images_site/Logo_pattern.jpg')",
                'logo-pattern-opacity': "url('/images_site/logo_pattern_opacity.png')",
                
            }
        }
    },
    plugins: [],
}


