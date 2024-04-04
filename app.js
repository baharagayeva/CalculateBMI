    document.getElementById("btnCalculate").addEventListener("click", async function () {
        const height = document.getElementById("height").value;
        const weight = document.getElementById("weight").value;
        const result = document.getElementById("result");

        let res = await fetch("https://localhost:7114/api/BodyMassIndex", {
            "method": "POST",
            "mode": "cors",
            "cache": "no-cache",
            "credentials": "same-origin",
            "headers": {
                "Content-Type": "application/json",
            },
            "body": JSON.stringify({ height: height, weight: weight })
        });

        
        result.textContent = await res.json();
      
       
    });
