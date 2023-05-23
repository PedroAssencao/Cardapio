document.getElementById('copyButton').addEventListener('click', function () {

    var dummyElement = document.getElementById('myInput');
    dummyElement.value = textToCopy;
    document.body.appendChild(dummyElement);
    dummyElement.select();
    document.execCommand('copy');
    document.body.removeChild(dummyElement);

    document.getElementById('textDisplay').textContent = textToCopy;
    alert('Texto copiado para a área de transferência!');
});