import React, { Component } from 'react';
import './Preloader.css';

export default class Preloader extends Component {
    render() {
        return (
            <div className="preloader-overlay">
                <div className="preloader">
                    <div className="lines">
                        <div className="line line-1"/>
                        <div className="line line-2"/>
                        <div className="line line-3"/>
                    </div>
                    <div className="loading-text">LOADING</div>
                </div>
            </div>
        );
    }
}
