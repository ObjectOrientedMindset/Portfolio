// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


let flip_card = (param, arg) => {
    switch (arg) {
        case 'flip_first':
            $('.card-reveal.' + param).css('transform', 'translateY(-100%)');
            break;
        case 'close_first':
            $('.card-reveal.' + param).css('transform', 'translateY(100%)');
            break;
        case 'flip_second':
            $('.card-reveal.' + param).css('transform', 'translateY(-100%)');
            break;
        case 'close_second':
            $('.card-reveal.' + param).css('transform', 'translateY(100%)');
            break;
        case 'flip_third':
            $('.card-reveal.' + param).css('transform', 'translateY(-100%)');
            break;
        case 'close_third':
            $('.card-reveal.' + param).css('transform', 'translateY(100%)');
            break;
        case 'flip_forth':
            $('.card-reveal.' + param).css('transform', 'translateY(-100%)');
            break;
        case 'close_forth':
            $('.card-reveal.' + param).css('transform', 'translateY(100%)');
            break;
        default:
            break;
    }
}