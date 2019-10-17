import React, { Component } from 'react';
import OwlCarousel from 'react-owl-carousel';
import './Testimonials.css';

export default class Testimonials extends Component {
    constructor(props) {
        super(props);
        this.state = {
            options: {
                autoplay: true,
                loop: true,
                margin: 0,
                nav: true,
                navClass: ['owl-prev waves-effect waves-cvitae', 'owl-next waves-effect waves-cvitae'],
                navSpeed: 1000,
                responsive: {
                    0: {
                        items: 1
                    }
                },
                smartSpeed: 1000
            }
        };
    }
    render() {
        let testimonials = [];
        this.props.testimonials.forEach(function(testimonial, i) {
            testimonials.push(<div className="item" key={i}>
                <p className="designation">{testimonial.position} at {testimonial.company}</p>
                <h4 className="name">{testimonial.firstname} {testimonial.lastname}</h4>
                <p className="message">{testimonial.testimony}</p>
            </div>);
        });
        return (
            <div id="testimonial" className="cvitae-section cvitae-testimonial">
                <div className="cvitae-container">
                    <div className="cvitae-section-content">
                        <div className="content-left">
                            <h3 className="cvitae-section-title">Testimonials</h3>
                            {/*<p></p>*/}
                        </div>
                        <div className="content-right">
                            <OwlCarousel className="testimonial-container" {...this.state.options}>
                                {testimonials}
                            </OwlCarousel>
                        </div>
                    </div>
                </div>
                <div className="parallax"/>
            </div>
        );
    }
}
