import React, { Component } from 'react';
import Slider01 from '../../images/Slider-01.jpg';
import jQuery from 'jquery';
import './Slider.css';

export default class Slider extends Component {
    componentDidMount() {
        setTimeout(() => jQuery('.slider').addClass('active'), 1000);      
    }
    render() {
        return (
            <div id="home" className="cvitae-section slider">
                <div className="cvitae-container">
                    <div className="slider-content">
                        <div className="box-container">
                            <p className="name">{this.props.info.firstname} {this.props.info.lastname}</p>
                            <p className="designation">{this.props.info.position}</p>
                        </div>
                        <img src={Slider01} className="image" alt={this.props.info.firstname} />
                    </div>
                </div>
            </div>
        );
    }
}
