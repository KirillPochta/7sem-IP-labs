var ta;
var ws = null;
var bstart;
var bstop;
window.onload = function () {
    if (Modernizr.websockets) {
        WriteMessage('support', 'да');
        ta = document.getElementById('ta');
        bstart = document.getElementById('bstart');
        bstop = document.getElementById('bstop');
        bstart.disabled = false;
        bstop.disabled = true;
    }
}

function WriteMessage(idspan, txt) {
    var span = document.getElementById(idspan);
    span.innerHTML = txt;
}

function exe_start() {
    if (ws == null) {
        ws = new WebSocket(`wss://${window.location.host}//websockets.websocketpka`);
        ws.onopen = function () { ws.send('Соединение'); }
        ws.onclose = function () { console.log('onclose', ws); }
        ws.onmessage = function (evt) { ta.innerHTML += '\n' + evt.data; }
        ws.onerror = function (err) { console.log(err) }
        bstart.disabled = true;
        bstop.disabled = false;
    }
}


function exe_stop() {
    console.log(ws);
    console.log(1);
    ws.send("stop");
    ws.close();
    ws = null;
    bstart.disabled = false;
    bstop.disabled = true;
}