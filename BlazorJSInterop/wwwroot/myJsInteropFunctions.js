window.Tools = {
    SetText:  function (newText, elemntRef) {
            console.log(newText);
            elemntRef.innerHTML = newText;
            //document.getElementById("title").innerHTML = newText;
        return newText;
    },
    csharpMethod: function (){
    DotNet.invokeMethodAsync('BlazorJSInterop', 'ReturnArrayAsync')
        .then(data => {
            data.push("Blazor");
            console.log(data);
        });
}
};
