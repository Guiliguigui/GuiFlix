import React, { useEffect, useState } from "react";
import { get } from '../../Service/Service';
import LoaderComponent from "../LoaderComponent/LoaderComponent";
import './headermediacomponent.css';

export default function HeaderMediaComponent(props) {
    const [randomMedia, setRandomMedia] = useState([]);
    const [isLoading, setIsLoading] = useState(true);
    useEffect(() => {
        get("Media/Random?quantity=1").then((res) => {
            setRandomMedia(res.data);
            setIsLoading(false);
        })
    }, [])
    const showHeader = () => {
        document.getElementById("backHeader").style.backgroundImage = "url(" + randomMedia[0].thumbnailLink + ")";
        return (
            <div className="textHeaderMedia">
                <div className="titleHeaderMedia">
                    {randomMedia[0].name}
                </div>
                <div className="descriptionHeaderMedia">
                    {randomMedia[0].description}
                </div>
                <button onClick={props.showDetails(randomMedia[0])}>Lire la suite...</button>
            </div>
        )
    }
    return (
        <div className="headerMedia" id="backHeader">
            <div>
                {isLoading ? <LoaderComponent /> : showHeader()}
            </div>
        </div>
    )
}