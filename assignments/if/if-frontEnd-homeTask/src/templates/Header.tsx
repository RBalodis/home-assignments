import React from 'react';

import { GlobalHeader } from '../components/global-header/GlobalHeader';

import { PrimaryNav } from '../components/global-header/PrimaryNav';
import { SecondaryNav } from '../components/global-header/SecondaryNav';

import { DesktopSecondaryNav } from './desktop/DesktopSecondaryNav';
import { MobilePrimaryNav } from './mobile/MobilePrimaryNav';

export const Header = () => {
    return (
        <GlobalHeader>
            <PrimaryNav>
                <MobilePrimaryNav />
            </PrimaryNav>

            <SecondaryNav>
                <DesktopSecondaryNav />
            </SecondaryNav>
        </GlobalHeader>
    );
};
