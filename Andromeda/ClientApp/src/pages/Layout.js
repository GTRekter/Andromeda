import React, { Component } from 'react';
import Navigation from '../components/navigation/Navigation';
import NavigationMobile from '../components/navigation/NavigationMobile';
import Preloader from '../components/preloader/Preloader';
//import jQuery from 'jquery';

export class Layout extends Component {
    constructor(props) {
        super(props);
        this.state = {
            loaded: false
        };
    }
    componentDidMount() {
        window.addEventListener('load', () => {
            this.setState({
                loaded: true
            });
        });  
    }
    render() {
        let loader = this.state.loaded ? null : <Preloader />;
        return (
            <div className="cvitae">
                {loader}
                <div className="cvitae-site-container">
                    <Navigation />
                    <NavigationMobile />
                    {this.props.children}
                </div>
            </div>         
        );
    }
}
