
function time(){
    document.getElementById('time').innerHTML=Date();
}
function knapTest(id){
    document.getElementById(id).innerHTML = "Den virker!"
}
function hideText(id){
    var x = document.getElementById(id);
    if (x.style.display === "block") {
        x.style.display = "none";
    } 
    else 
    {
    x.style.display = "block";
    }
}
function addText(id){
    var para = document.createElement('p');
    var node = document.createTextNode('Tak for du tilføjede mig!');
    para.appendChild(node);
    var element = document.getElementById(id);
    element.appendChild(para);
}
function removeText(id){
    var elmnt = document.getElementById(id);
    elmnt.remove();
}
function arrayPrint(id){
    var array = ["1 får!", "2 får!", "3 får!", "4 får!", "5 får!", "6 får!"]
    var element;
    var node;
    var i = 0;
    while (array.length > i){
        setTimeout(5000);
        var para = document.createElement('p');
        node = document.createTextNode(array[i]);
        para.appendChild(node);
        element = document.getElementById(id);
        element.appendChild(para);
        i++;
    }
}