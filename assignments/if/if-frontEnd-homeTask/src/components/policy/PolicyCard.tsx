import React, { ReactNode } from 'react';

export type Policy = {
    title: ReactNode;
};

// TODO: Create policy card using If Design System
export const PolicyCard = ({ policy }: { policy: Policy }) => {
    return (
        // eslint-disable-next-line no-console
        <button onClick={() => console.log(policy.title)}>
            {policy.title}
        </button>
    );
};
