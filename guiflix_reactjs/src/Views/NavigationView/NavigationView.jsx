import { get } from "../../Service/Service";
import React, { useEffect, useState } from "react";
import { useLocation } from "react-router-dom";
import HeaderMediaComponent from "../../Components/HeaderMediaComponent/HeaderMediaComponent";
import MediaDetailsComponent from "../../Components/MediaDetailsComponent/MediaDetailsComponent";
import MediaListComponent from "../../Components/MediaListComponent/MediaListComponent";
import './navigationview.css';
import LoaderComponent from "../../Components/LoaderComponent/LoaderComponent";
import { v4 as uuidv4 } from 'uuid';

export default function NavigationView(props) {
    const [randomMedia, setRandomMedia] = useState([]);
    const [randomMedias, setRandomMedias] = useState([]);
    const [media, setMedia] = useState([]);
    const [isDetails, setIsDetails] = useState(false);
    const [isHeaderLoading, setIsHeaderLoading] = useState(true);
    const [isLoading, setIsLoading] = useState(true);
    const [isRandomLoading, setIsRandomLoading] = useState(true);
    const [categories, setCategories] = useState([]);
    const location = useLocation();

    useEffect(() => {
        isDetails ? document.getElementById("blurDiv").style.filter = "blur(7px)" : document.getElementById("blurDiv").style.filter = "blur(0)"
    }, [isDetails])
    useEffect(() => {
        const mediaTypePartialRequest = props.mediaType==null?"":`&mediaType=${props.mediaType}`
        const JWT = localStorage.getItem("GuiFlix_JWT");
        get("Media/Random?quantity=1" + mediaTypePartialRequest, {
            headers: { Authorization: `Bearer ${JWT}` }
        }).then((res) => {
            setRandomMedia(res.data);
            setIsHeaderLoading(false);
        }).catch(err => {
            console.log(err.message)
        })
        get("Media/Random?quantity=10" + mediaTypePartialRequest, {
            headers: { Authorization: `Bearer ${JWT}` }
        }).then((res) => {
            setRandomMedias(res.data);
            setIsRandomLoading(false);
        }).catch(err => {
            console.log(err.message)
        })
        get("Category/Random?quantity=3" + mediaTypePartialRequest, {
            headers: { Authorization: `Bearer ${JWT}` }
        }).then((res) => {
            setCategories(res.data);
            setIsLoading(false);
        }).catch(err => {
            console.log(err.message)
        })
    }, [location])
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
                {props.mediaType == null?
                 props.profileSelected.lists.map((list)=>{
                    return(
                    <MediaListComponent key={uuidv4()} medias={list.medias} nameCarousel={list.name} showDetails={showDetails}/>
                    )
                }):""}
                {isLoading ? <LoaderComponent /> : categories.map((category) => {
                    if(category.medias.length>0)
                    return (
                        <MediaListComponent key={uuidv4()} medias={category.medias} nameCarousel={category.name} showDetails={showDetails} />
                    )
                })}
                {isRandomLoading? <LoaderComponent/> : <MediaListComponent medias={randomMedias} nameCarousel={"Our selection for "+props.profileSelected.userName} showDetails={showDetails}/>}

            </div>
            {
                isDetails ? <MediaDetailsComponent mediaId={media.id} setIsDetails={setIsDetails} profileSelected={props.profileSelected}/> : ""
            }
        </div>
    )
}