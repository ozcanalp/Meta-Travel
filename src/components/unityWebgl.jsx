import React , {useEffect,useState}from "react";
import Unity, { UnityContext } from "react-unity-webgl";

const unityContext = new UnityContext({
  loaderUrl: "/webgl/Build/Meta-test.loader.js",
  dataUrl: "/webgl/Build/Meta-test.data",
  frameworkUrl: "/webgl/Build/Meta-test.framework.js",
  codeUrl: "/webgl/Build/Meta-test.wasm",
});

function App() {
    const [progression, setProgression] = useState(0);

  useEffect(function () {
      console.log(unityContext)
    unityContext.on("progress", function (progression) {
      setProgression(progression);
    });
  }, []);


  return(<div className="unityContainer center">
       {progression!==1&&<p>Loading {Math.floor(progression * 100)} %</p>} 
       <Unity 
       style={{
        height: "90%",
        width: "90%",
        border: "2px solid black",
        background: "grey",
      }}
       unityContext={unityContext} />
  </div>)
}

export default App