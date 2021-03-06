/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_isalnum.c                                       :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/02/24 15:27:41 by mfeijao           #+#    #+#             */
/*   Updated: 2021/02/24 15:28:19 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

int	ft_isalnum(int i)
{
	if ((i >= '0' && i <= '9') ||
			(i >= 'A' && i <= 'Z') ||
			(i >= 'a' && i <= 'z'))
		return (1);
	return (0);
}
