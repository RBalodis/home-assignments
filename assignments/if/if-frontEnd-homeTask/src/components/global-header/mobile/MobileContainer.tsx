import React, { HTMLAttributes, ReactNode } from 'react';
import classnames from 'classnames';

export interface MobileContainerProps {
    children: ReactNode;
    className?: HTMLAttributes<HTMLDivElement>['className'];
}

export const MobileContainer = ({
    children,
    className,
}: MobileContainerProps) => {
    return <div className={classnames('if mobile', className)}>{children}</div>;
};
