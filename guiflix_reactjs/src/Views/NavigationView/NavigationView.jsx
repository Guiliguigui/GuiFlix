import { get } from "../../Service/Service";
import React, { useEffect, useState } from "react";
import HeaderMediaComponent from "../../Components/HeaderMediaComponent/HeaderMediaComponent";
import MediaDetailsComponent from "../../Components/MediaDetailsComponent/MediaDetailsComponent";
import MediaListComponent from "../../Components/MediaListComponent/MediaListComponent";
import './navigationview.css';
import LoaderComponent from "../../Components/LoaderComponent/LoaderComponent";

export default function NavigationView() {
    const [randomMedia, setRandomMedia] = useState([]);
    const [media, setMedia] = useState([]);
    const [isDetails, setIsDetails] = useState(false);
    const [isHeaderLoading, setIsHeaderLoading] = useState(true);
    const [isLoading, setIsLoading] = useState(true);
    const [category, setCategory] = useState([]);
    const JWT = localStorage.getItem("GuiFlix_JWT");


    useEffect(() => {
        isDetails ? document.getElementById("blurDiv").style.filter = "blur(7px)" : document.getElementById("blurDiv").style.filter = "blur(0)"
    }, [isDetails])
    useEffect(() => {
        get("Media/Random?quantity=1", {
            headers: { Authorization: `Bearer ${JWT}` }
        }).then((res) => {
            setRandomMedia(res.data);
            setIsHeaderLoading(false);
        }).catch(err => {
            console.log(err.message)
        })
        get("Category/Random?quantity=2", {
            headers: { Authorization: `Bearer ${JWT}` }
        }).then((res) => {
            setCategory(res.data);
            setIsLoading(false);
        }).catch(err => {
            console.log(err.message)
        })
    }, [])
    const showDetails = (id) => {
        get("Media/" + id).then((res) => {
            setMedia(res.data);
            setIsDetails(true);
        })
    }

    return (
        <div id="navigationView">
            <div id="blurDiv">
                {isHeaderLoading ? <LoaderComponent /> : <HeaderMediaComponent showDetails={showDetails} randomMedia={randomMedia} />}
                {isLoading ? <LoaderComponent /> : category.map((category, index) => {
                    return (
                        <MediaListComponent key={index} medias={category.medias} nameCarousel={category.name} showDetails={showDetails} />
                    )

                })}
            </div>
            {
                isDetails ? <MediaDetailsComponent mediaId={media.id} setIsDetails={setIsDetails} /> : ""
            }
        </div>
    )
}