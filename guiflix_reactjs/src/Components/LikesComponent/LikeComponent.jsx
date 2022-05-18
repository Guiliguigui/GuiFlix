import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import React, { useEffect, useState } from 'react';
import { useParams } from 'react-router-dom';
import { get, post } from "../../Service/Service";
import { faHeart, faThumbsUp, faThumbsDown, faHeartCirclePlus } from "@fortawesome/free-solid-svg-icons";
import "./likecomponent.css";

export default function LikeComponent(props) {
    const LikeTypes = [faHeart, faThumbsUp, faThumbsDown]
    const [like, setLike] = useState(faHeartCirclePlus);
    const { id } = useParams();
    const JWT = localStorage.getItem("GuiFlix_JWT");

    useEffect(() => {
        get(`Like/IsMediaLiked?profileId=${props.profileSelected.id}&mediaId=${props.mediaId}`, {
            headers: { Authorization: `Bearer ${JWT}` }
        }).then((res) => {
            setLike(LikeTypes[res.data.type])
        }).catch((err) => {
            setLike(faHeartCirclePlus)
        })
    }, [])

    // function changeLike(type) {
    //     post("LikeMedia",
    //         {
    //             type: type,
    //             profileId: props.profileSelected.profileId,
    //             mediaId: props.mediaId
    //         },
    //         {
    //             headers: { Authorization: `Bearer ${JWT}` }
    //         }
    //     ).then(res => {
    //         setLike(LikeTypes[res.data.type])
    //     }).catch((err) => {
    //         console.error(err.message);
    //     })
    // }

    return (
        <button className='like'>
            <FontAwesomeIcon icon={like} />
        </button>
    );
}


