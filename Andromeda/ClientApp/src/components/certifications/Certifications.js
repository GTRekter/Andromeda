import React, { Component } from 'react';
import OwlCarousel from 'react-owl-carousel';
import './Certifications.css';

export default class Certifications extends Component {
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
        let certifications = [];
        this.props.certifications.forEach(function(certification, i) {
            certifications.push(<div className="item" key={i}>
                <p className="certification-date">{certification.dateEnd}</p>
                <h4 className="certification-title">{certification.name}</h4>
                <p className="certification-detail">{certification.description}</p>
            </div>);
        });
        return (
            <div id="certification" className="cvitae-section cvitae-certifications">
                <div className="cvitae-container">
                    <div className="cvitae-section-content">
                        <div className="content-left">
                            <h3 className="cvitae-section-title">Certifications</h3>
                            {/*<p></p>*/}
                        </div>
                        <div className="content-right">
                            <OwlCarousel className="certification-container" {...this.state.options}>
                                {certifications}
                            </OwlCarousel>
                        </div>
                    </div>
                </div>
                <div className="parallax" />
            </div>
        );
    }
}
